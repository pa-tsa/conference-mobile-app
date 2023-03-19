using System;

namespace PaTsa.Conference.App.Maui.Models;

public class ConferenceEventModel
{
    public string Description { get; set; }

    public DateTime EndDateTime { get; set; }

    public string Name { get; set; }

    public string Id { get; set; }

    public string Location { get; set; }

    public string Type { get; set; }

    public string TypeShortCode => "MS";

    public DateTime StartDateTime { get; set; }
}
