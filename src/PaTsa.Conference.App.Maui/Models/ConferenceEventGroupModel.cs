using System.Collections.Generic;

namespace PaTsa.Conference.App.Maui.Models;

public class ConferenceEventGroupModel : List<ConferenceEventModel>
{
    public string Name { get; set; }

    //public ConferenceEventGroupModel(string name, IEnumerable<ConferenceEventModel> conferenceEventModels) : base(conferenceEventModels)
    //{
    //    Name = name;
    //}
}
