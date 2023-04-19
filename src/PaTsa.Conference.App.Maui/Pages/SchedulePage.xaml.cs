using System;
using Microsoft.Maui.Controls;
using PaTsa.Conference.App.Maui.ViewModels;

namespace PaTsa.Conference.App.Maui.Pages;

public partial class SchedulePage
{
    protected ScheduleViewModel ScheduleViewModel => BindingContext as ScheduleViewModel;

    public SchedulePage(ScheduleViewModel scheduleViewModel)
    {
        InitializeComponent();
        BindingContext = scheduleViewModel;
    }

    private async void AllEventsButton_OnClicked(object sender, EventArgs e)
    {
        AllEventsButton.Style = Application.Current?.Resources["RedButtonFilled"] as Style;
        FavoriteEventsButton.Style = Application.Current?.Resources["RedButtonOutline"] as Style;

        EventsFilterButton.IsEnabled = true;

        await ScheduleViewModel.ShowAllConferenceEventsCommand.ExecuteAsync(null);
    }

    private void EventsFilterButton_OnClicked(object sender, EventArgs e)
    {
        ShowHideEventsFilter();
    }

    private async void FavoriteEventsButton_OnClicked(object sender, EventArgs e)
    {
        AllEventsButton.Style = Application.Current?.Resources["RedButtonOutline"] as Style;
        FavoriteEventsButton.Style = Application.Current?.Resources["RedButtonFilled"] as Style;

        EventsFilterButton.IsEnabled = false;
        EventsFilterVerticalStackLayout.IsVisible = false;

        await ScheduleViewModel.ShowFavoriteConferenceEventsCommand.ExecuteAsync(null);
    }

    private void FilterEventsButton_OnClicked(object sender, EventArgs e)
    {
        ShowHideEventsFilter();
    }

    private void ShowHideEventsFilter()
    {
        EventsFilterVerticalStackLayout.IsVisible = !EventsFilterVerticalStackLayout.IsVisible;
    }

    private void FavoriteImageButton_OnClicked(object sender, EventArgs e)
    {
        if (ScheduleViewModel.ShowFavoritesOnly) return;

        ((ImageButton)sender).Source = new FileImageSource
        {
            File = "heart_fill.png"
        };
    }
}
