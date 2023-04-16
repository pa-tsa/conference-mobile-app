using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using PaTsa.Conference.App.Maui.Models;

namespace PaTsa.Conference.App.Maui.Services;

public class ConferenceEventService
{
    private readonly HttpClient _httpClient;

    public ConferenceEventService()
    {
        _httpClient = new HttpClient();
    }

    private static HttpRequestMessage ConstructGetConferenceEventsRequest(string typesFilter, int pageNumber)
    {
        var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            $"https://pa-tsa-conference-app-api-app.azurewebsites.net/api/ConferenceEvents?types={typesFilter}&pageNumber={pageNumber}&pageSize=20");

        return httpRequestMessage;
    }

    public async Task<List<ConferenceEventModel>> GetConferenceEvents(string typesFilter, int pageNumber)
    {
        var httpResponseMessage = await _httpClient.SendAsync(ConstructGetConferenceEventsRequest(typesFilter, pageNumber));

        if (!httpResponseMessage.IsSuccessStatusCode) return new List<ConferenceEventModel>();

        return await httpResponseMessage.Content.ReadFromJsonAsync<List<ConferenceEventModel>>();
    }
}
