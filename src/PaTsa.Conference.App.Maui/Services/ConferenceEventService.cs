using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using PaTsa.Conference.App.Maui.Models;

namespace PaTsa.Conference.App.Maui.Services;

public class ConferenceEventService
{
    public const int PageSize = 30;

    private readonly HttpClient _httpClient;

    public ConferenceEventService()
    {
        _httpClient = new HttpClient();
    }

    private static HttpRequestMessage ConstructGetConferenceEventsRequest(
        string eventIdsFilter,
        string typesFilter,
        int pageNumber)
    {
        var queryStringBuilder = new StringBuilder();

        if (!string.IsNullOrWhiteSpace(eventIdsFilter))
        {
            queryStringBuilder.Append(queryStringBuilder.Length == 0 ? "?" : "&");
            queryStringBuilder.Append($"eventIds={eventIdsFilter}");
        }

        if (!string.IsNullOrWhiteSpace(typesFilter))
        {
            queryStringBuilder.Append(queryStringBuilder.Length == 0 ? "?" : "&");
            queryStringBuilder.Append($"types={typesFilter}");
        }

        queryStringBuilder.Append(queryStringBuilder.Length == 0 ? "?" : "&");
        queryStringBuilder.Append($"pageNumber={pageNumber}");

        queryStringBuilder.Append(queryStringBuilder.Length == 0 ? "?" : "&");
        queryStringBuilder.Append($"pageSize={PageSize}");

        var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            $"https://pa-tsa-conference-app-api-app.azurewebsites.net/api/ConferenceEvents{queryStringBuilder}");

        return httpRequestMessage;
    }

    public async Task<List<ConferenceEventModel>> GetConferenceEvents(
        IEnumerable<string> eventIds,
        IEnumerable<string> types,
        int pageNumber)
    {
        var httpResponseMessage = await _httpClient.SendAsync(
            ConstructGetConferenceEventsRequest(
                string.Join(',', eventIds),
                string.Join(',', types),
                pageNumber));

        if (!httpResponseMessage.IsSuccessStatusCode) return new List<ConferenceEventModel>();

        return await httpResponseMessage.Content.ReadFromJsonAsync<List<ConferenceEventModel>>();
    }
}
