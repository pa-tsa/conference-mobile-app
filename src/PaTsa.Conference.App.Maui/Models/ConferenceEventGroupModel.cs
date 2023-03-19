using System.Collections.Generic;

namespace PaTsa.Conference.App.Maui.Models;

public class ConferenceEventGroupModel : List<ConferenceEventModel>
{
    public string Name { get; set; }
}
