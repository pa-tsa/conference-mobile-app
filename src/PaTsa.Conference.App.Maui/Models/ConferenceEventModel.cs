using System;

namespace PaTsa.Conference.App.Maui.Models;

public class ConferenceEventModel
{
    public DateTime EndDateTime { get; set; }

    public string EventName { get; set; }

    public string Id { get; set; }

    public DateTime StartDateTime { get; set; }

    public string SchoolLevel { get; set; }

    public string Location { get; set; }
}
