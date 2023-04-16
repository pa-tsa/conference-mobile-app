using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using PaTsa.Conference.App.Maui.Models;
using PaTsa.Conference.App.Maui.Services;

namespace PaTsa.Conference.App.Maui.ViewModels;

public partial class ScheduleViewModel : BaseViewModel
{
    private readonly ConferenceEventService _conferenceEventService;
    private readonly List<string> _favoriteEventsList;
    private bool _allEventsLoaded;
    private int _pageNumber;

    private bool _showFavoritesOnly;

    [ObservableProperty]private bool _showHighSchoolEvents;

    [ObservableProperty]private bool _showMiddleSchoolEvents;

    [ObservableProperty]private bool _showSpecialInterestsEvents;

    public ObservableCollection<ConferenceEventModel> ConferenceEvents { get; } = new();

    public ScheduleViewModel(ConferenceEventService conferenceEventService)
    {
        _conferenceEventService = conferenceEventService;
        //TODO: Load from local config
        _favoriteEventsList = new List<string>();
        _pageNumber = 0;
        Title = "Conference Schedule";

        //TODO: Load from local config
        _showFavoritesOnly = false;
        _showHighSchoolEvents = true;
        _showMiddleSchoolEvents = true;
        _showSpecialInterestsEvents = true;
    }

    private string BuildTypesFilter()
    {
        var typesList = new List<string>();

        if (ShowHighSchoolEvents) typesList.Add("High School");

        if (ShowMiddleSchoolEvents) typesList.Add("Middle School");

        if (ShowSpecialInterestsEvents) typesList.Add("Special Interest");

        return typesList.Any()
            ? string.Join(',', typesList)
            : string.Empty;
    }

    [RelayCommand]
    private void FavoriteConferenceEvent(string eventName)
    {
        if (_favoriteEventsList.Contains(eventName))
            _favoriteEventsList.Remove(eventName);
        else
            _favoriteEventsList.Add(eventName);
    }

    private async Task FetchConferenceEvents()
    {
        var typesFilter = BuildTypesFilter();

        var conferenceEventModels = await _conferenceEventService.GetConferenceEvents(typesFilter, _pageNumber);

        if (conferenceEventModels.Any())
        {
            if (_showFavoritesOnly) conferenceEventModels = conferenceEventModels.Where(_ => _favoriteEventsList.Contains(_.EventId)).ToList();

            conferenceEventModels.ForEach(ConferenceEvents.Add);
        }
        else
        {
            _allEventsLoaded = true;
        }
    }

    [RelayCommand]
    private async Task FilterConferenceEventsAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;

            ConferenceEvents.Clear();

            _allEventsLoaded = false;
            _pageNumber = 1;

            await FetchConferenceEvents();
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

    [RelayCommand]
    private async Task LoadConferenceEventsPageAsync()
    {
        if (IsBusy || _allEventsLoaded) return;

        try
        {
            IsBusy = true;

            _pageNumber++;

            await FetchConferenceEvents();
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

    [RelayCommand]
    private async Task ShowFavoriteConferenceEventsAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;

            ConferenceEvents.Clear();

            _allEventsLoaded = false;
            _pageNumber = 1;
            _showFavoritesOnly = true;

            ShowHighSchoolEvents = true;
            ShowMiddleSchoolEvents = true;
            ShowSpecialInterestsEvents = true;

            await FetchConferenceEvents();
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
