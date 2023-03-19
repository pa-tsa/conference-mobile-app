using Microsoft.Maui.Controls;
using PaTsa.Conference.App.Maui.ViewModels;

namespace PaTsa.Conference.App.Maui.Pages;

public partial class SchedulePage : ContentPage
{
    public SchedulePage(ConferenceEventGroupViewModel conferenceEventGroupViewModel)
    {
        InitializeComponent();
        BindingContext = conferenceEventGroupViewModel;
    }
}
