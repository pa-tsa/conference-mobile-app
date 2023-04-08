using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using PaTsa.Conference.App.Maui.Models;
using PaTsa.Conference.App.Maui.Services;

namespace PaTsa.Conference.App.Maui.ViewModels;

public partial class ConferenceEventGroupViewModel : BaseViewModel
{
    private readonly ConferenceEventService _conferenceEventService;
    private bool _allEventsLoaded;
    private int _pageNumber;

    public ObservableCollection<ConferenceEventModel> ConferenceEvents { get; } = new();

    public ConferenceEventGroupViewModel(ConferenceEventService conferenceEventService)
    {
        _conferenceEventService = conferenceEventService;
        _pageNumber = 0;
        Title = "Conference Schedule";
    }


    [RelayCommand]
    private async Task LoadConferenceEventsAsync()
    {
        if (IsBusy || _allEventsLoaded) return;

        try
        {
            IsBusy = true;

            _pageNumber++;

            var conferenceEventModels = await _conferenceEventService.GetConferenceEvents(_pageNumber);

            if (conferenceEventModels.Any())
                conferenceEventModels.ForEach(ConferenceEvents.Add);
            else
                _allEventsLoaded = true;
        }
        catch (Exception exception)
        {
            Debug.WriteLine($"Unable to get conference events: {exception.Message}");
            await Shell.Current.DisplayAlert("Error!", exception.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}
