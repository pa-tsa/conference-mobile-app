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
    private bool _allEventsLoaded;
    private readonly ConferenceEventService _conferenceEventService;
    private readonly List<string> _favoriteEventsList;
    private int _pageNumber;

    private bool _showFavoritesOnly;

    [ObservableProperty]private bool _showHighSchoolEvents;

    [ObservableProperty]private bool _showMiddleSchoolEvents;

    [ObservableProperty]private bool _showSpecialInterestsEvents;

    public bool ShowFavoritesOnly => _showFavoritesOnly;

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

    private List<string> BuildTypesFilter()
    {
        var typesList = new List<string>();

        if (ShowHighSchoolEvents) typesList.Add("High School");

        if (ShowMiddleSchoolEvents) typesList.Add("Middle School");

        if (ShowSpecialInterestsEvents) typesList.Add("Special Interest");

        return typesList;
    }

    [RelayCommand]
    private void FavoriteConferenceEvent(string eventName)
    {
        bool isFavorite;
        if (_favoriteEventsList.Contains(eventName))
        {
            isFavorite = false;
            _favoriteEventsList.Remove(eventName);
        }
        else
        {
            isFavorite = true;
            _favoriteEventsList.Add(eventName);
        }

        foreach (var conferenceEventModel in ConferenceEvents.Where(_=>_.EventId == eventName))
        {
            conferenceEventModel.IsFavorite = isFavorite;
        }
    }

    private async Task FetchConferenceEvents()
    {
        var conferenceEventModels = await _conferenceEventService.GetConferenceEvents(
            _showFavoritesOnly ? _favoriteEventsList : new List<string>(0),
            BuildTypesFilter(),
            _pageNumber);

        if (conferenceEventModels.Any())
        {
            conferenceEventModels.ForEach(_=> _.IsFavorite = _favoriteEventsList.Contains(_.EventId));
            conferenceEventModels.ForEach(ConferenceEvents.Add);
        }

        if (conferenceEventModels.Count < ConferenceEventService.PageSize)
            _allEventsLoaded = true;
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
    private async Task InitialLoadOfConferenceEventsAsync()
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
    private async Task LoadConferenceEventsPageAsync()
    {
        if (IsBusy || _allEventsLoaded) return;

        try
        {
            IsBusy = true;

            //TODO: Figure out what to display
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
    private async Task ShowAllConferenceEventsAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;

            ConferenceEvents.Clear();

            _allEventsLoaded = false;
            _pageNumber = 1;
            _showFavoritesOnly = false;

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
