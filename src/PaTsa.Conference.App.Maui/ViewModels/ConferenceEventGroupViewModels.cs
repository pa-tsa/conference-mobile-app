using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using PaTsa.Conference.App.Maui.Models;
using PaTsa.Conference.App.Maui.Services;

namespace PaTsa.Conference.App.Maui.ViewModels;

public partial class ConferenceEventGroupViewModel : BaseViewModel
{
    private readonly ConferenceEventService _conferenceEventService;

    public ObservableCollection<ConferenceEventGroupModel> ConferenceEventGroups { get; } = new();

    public ConferenceEventGroupViewModel(ConferenceEventService conferenceEventService)
    {
        Title = "Conference Schedule";
        _conferenceEventService = conferenceEventService;
    }

    [RelayCommand]
    private async Task GetConferenceEventGroupsAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;

            var refreshedConferenceEventGroups = _conferenceEventService.GetConferenceEventGroups();

            if (ConferenceEventGroups.Count != 0) ConferenceEventGroups.Clear();

            refreshedConferenceEventGroups.ForEach(ConferenceEventGroups.Add);
        }
        catch (Exception exception)
        {
            Debug.WriteLine($"Unable to get monkeys: {exception.Message}");
            await Shell.Current.DisplayAlert("Error!", exception.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }

}
