using System;
using System.Diagnostics;

namespace PaTsa.Conference.App.Maui.Models;

[DebuggerDisplay("{Type} - {Name}")]
public class ConferenceEventModel
{
    public string Description { get; set; }

    public DateTime EndDateTime { get; set; }

    public string Id { get; set; }

    public DateTime LocalEndDateTime => EndDateTime.ToLocalTime();

    public DateTime LocalStartDateTime => StartDateTime.ToLocalTime();

    public string Location { get; set; }

    public string Name { get; set; }

    public DateTime StartDateTime { get; set; }

    public string Type { get; set; }

    public string TypeShortCode => Type switch
    {
        "Middle School" => "MS",
        "High School" => "HS",
        "Special Interest" => "SI",
        _ => "UKN"
    };
}
