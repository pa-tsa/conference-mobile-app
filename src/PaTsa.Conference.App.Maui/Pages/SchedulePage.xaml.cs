using System;
using Microsoft.Maui.Controls;
using PaTsa.Conference.App.Maui.ViewModels;

namespace PaTsa.Conference.App.Maui.Pages;

public partial class SchedulePage
{
    public SchedulePage(ConferenceEventGroupViewModel conferenceEventGroupViewModel)
    {
        InitializeComponent();
        BindingContext = conferenceEventGroupViewModel;
    }

    private void AllEventsButton_OnClicked(object sender, EventArgs e)
    {
        AllEventsButton.Style = Application.Current?.Resources["RedButtonFilled"] as Style;
        FavoriteEventsButton.Style = Application.Current?.Resources["RedButtonOutline"] as Style;

        EventsFilterButton.IsEnabled = true;
    }

    private void FavoriteEventsButton_OnClicked(object sender, EventArgs e)
    {
        AllEventsButton.Style = Application.Current?.Resources["RedButtonOutline"] as Style;
        FavoriteEventsButton.Style = Application.Current?.Resources["RedButtonFilled"] as Style;

        EventsFilterButton.IsEnabled = false;
        EventsFilterVerticalStackLayout.IsVisible = false;
    }

    private void EventsFilterButton_OnClicked(object sender, EventArgs e)
    {
        EventsFilterVerticalStackLayout.IsVisible = !EventsFilterVerticalStackLayout.IsVisible;
    }
}