using System;
using System.Collections.Generic;
using System.Linq;
using PaTsa.Conference.App.Maui.Models;

namespace PaTsa.Conference.App.Maui.Services;

public class ConferenceEventService
{
    private List<ConferenceEventModel> GenerateData()
    {
        return new List<ConferenceEventModel>
        {
            new()
            {
                Type = "Middle School", Name = "Biotechnology", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Biotechnology", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/20/2023 15:00"), EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Biotechnology", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Career Prep", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/21/2023 09:00"), EndDateTime = DateTime.Parse("04/21/2023 12:00"), Location = "Ski Lodge - Foggy Brews"
            },
            new()
            {
                Type = "Middle School", Name = "Challenging Technology Issues", Description = "Sign-up",
                StartDateTime = DateTime.Parse("04/19/2023 18:00"), EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Online Sign Up"
            },
            new()
            {
                Type = "Middle School", Name = "Challenging Technology Issues", Description = "Contest",
                StartDateTime = DateTime.Parse("04/20/2023 09:30"), EndDateTime = DateTime.Parse("04/20/2023 11:30"), Location = "Chestnut"
            },
            new()
            {
                Type = "Middle School", Name = "Challenging Technology Issues", Description = "Prep", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 11:30"), Location = "Evergreen"
            },
            new()
            {
                Type = "Middle School", Name = "Challenging Technology Issues", Description = "Contest",
                StartDateTime = DateTime.Parse("04/20/2023 12:30"), EndDateTime = DateTime.Parse("04/20/2023 14:30"), Location = "Chestnut"
            },
            new()
            {
                Type = "Middle School", Name = "Challenging Technology Issues", Description = "Prep", StartDateTime = DateTime.Parse("04/20/2023 13:30"),
                EndDateTime = DateTime.Parse("04/20/2023 16:00"), Location = "Evergreen"
            },
            new()
            {
                Type = "Middle School", Name = "Chapter Team", Description = "Testing", StartDateTime = DateTime.Parse("04/19/2023 17:00"),
                EndDateTime = DateTime.Parse("04/19/2023 21:00"), Location = "Sunburst"
            },
            new()
            {
                Type = "Middle School", Name = "Chapter Team", Description = "Testing", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 11:00"), Location = "Snowflake"
            },
            new()
            {
                Type = "Middle School", Name = "Chapter Team", Description = "Semi-finals Contest", StartDateTime = DateTime.Parse("04/21/2023 09:00"),
                EndDateTime = DateTime.Parse("04/21/2023 12:00"), Location = "Dogwood"
            },
            new()
            {
                Type = "Middle School", Name = "Children's Stories", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Children's Stories", Description = "Semi-finals", StartDateTime = DateTime.Parse("04/20/2023 18:30"),
                EndDateTime = DateTime.Parse("04/20/2023 21:30"), Location = "Laurel"
            },
            new()
            {
                Type = "Middle School", Name = "Children's Stories", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Coding", Description = "Testing", StartDateTime = DateTime.Parse("04/19/2023 17:00"),
                EndDateTime = DateTime.Parse("04/19/2023 21:00"), Location = "Sunburst"
            },
            new()
            {
                Type = "Middle School", Name = "Coding", Description = "Testing", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 11:00"), Location = "Snowflake"
            },
            new()
            {
                Type = "Middle School", Name = "Coding", Description = "Semi-finals", StartDateTime = DateTime.Parse("04/20/2023 18:00"),
                EndDateTime = DateTime.Parse("04/20/2023 22:00"), Location = "Alpine"
            },
            new()
            {
                Type = "Middle School", Name = "Community Service Video", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/21/2023 09:00"), EndDateTime = DateTime.Parse("04/21/2023 12:00"), Location = "Ski Lodge - Foggy Brews"
            },
            new()
            {
                Type = "Middle School", Name = "Computer-Aided Design Foundations", Description = "Set-up",
                StartDateTime = DateTime.Parse("04/21/2023 07:00"), EndDateTime = DateTime.Parse("04/21/2023 07:45"), Location = "Alpine"
            },
            new()
            {
                Type = "Middle School", Name = "Computer-Aided Design Foundations", Description = "Contest",
                StartDateTime = DateTime.Parse("04/21/2023 08:00"), EndDateTime = DateTime.Parse("04/21/2023 11:30"), Location = "Alpine"
            },
            new()
            {
                Type = "Middle School", Name = "Computer-Aided Design Foundations", Description = "Pick-up",
                StartDateTime = DateTime.Parse("04/21/2023 17:00"), EndDateTime = DateTime.Parse("04/21/2023 18:00"), Location = "Alpine"
            },
            new()
            {
                Type = "Middle School", Name = "Construction Challenge", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Construction Challenge", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/20/2023 15:00"), EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Construction Challenge", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Cybersecurity", Description = "Testing", StartDateTime = DateTime.Parse("04/19/2023 17:00"),
                EndDateTime = DateTime.Parse("04/19/2023 21:00"), Location = "Sunburst"
            },
            new()
            {
                Type = "Middle School", Name = "Cybersecurity", Description = "Testing", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 11:00"), Location = "Snowflake"
            },
            new()
            {
                Type = "Middle School", Name = "Cybersecurity", Description = "Semi-finalist Presentations",
                StartDateTime = DateTime.Parse("04/20/2023 19:00"), EndDateTime = DateTime.Parse("04/20/2023 21:00"), Location = "Seasons #4"
            },
            new()
            {
                Type = "Middle School", Name = "Data Science and Analytics", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Data Science and Analytics", Description = "Prep", StartDateTime = DateTime.Parse("04/20/2023 19:00"),
                EndDateTime = DateTime.Parse("04/20/2023 20:30"), Location = "Seasons #2"
            },
            new()
            {
                Type = "Middle School", Name = "Data Science and Analytics", Description = "Semi-finalist Presentations",
                StartDateTime = DateTime.Parse("04/20/2023 19:30"), EndDateTime = DateTime.Parse("04/20/2023 21:00"), Location = "Seasons #1"
            },
            new()
            {
                Type = "Middle School", Name = "Data Science and Analytics", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Digital Photography", Description = "Semi-finals", StartDateTime = DateTime.Parse("04/20/2023 14:00"),
                EndDateTime = DateTime.Parse("04/20/2023 17:30"), Location = "Alpine"
            },
            new()
            {
                Type = "Middle School", Name = "Dragster", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 19:00"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "Dragster", Description = "Races", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 17:00"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "Dragster", Description = "Semi-finalist Interviews", StartDateTime = DateTime.Parse("04/20/2023 16:00"),
                EndDateTime = DateTime.Parse("04/20/2023 19:00"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "Dragster", Description = "Pick-up", StartDateTime = DateTime.Parse("04/20/2023 17:00"),
                EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "Electrical Applications", Description = "Testing", StartDateTime = DateTime.Parse("04/19/2023 17:00"),
                EndDateTime = DateTime.Parse("04/19/2023 21:00"), Location = "Sunburst"
            },
            new()
            {
                Type = "Middle School", Name = "Electrical Applications", Description = "Testing", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 11:00"), Location = "Snowflake"
            },
            new()
            {
                Type = "Middle School", Name = "Electrical Applications", Description = "Semi-finals", StartDateTime = DateTime.Parse("04/21/2023 15:30"),
                EndDateTime = DateTime.Parse("04/21/2023 16:30"), Location = "Fox Den"
            },
            new()
            {
                Type = "Middle School", Name = "Essays on Technology", Description = "Contest - Outline",
                StartDateTime = DateTime.Parse("04/20/2023 10:00"), EndDateTime = DateTime.Parse("04/20/2023 12:00"), Location = "Fox Den"
            },
            new()
            {
                Type = "Middle School", Name = "Essays on Technology", Description = "Semi-finals - Essay",
                StartDateTime = DateTime.Parse("04/21/2023 12:30"), EndDateTime = DateTime.Parse("04/21/2023 14:30"), Location = "Fox Den"
            },
            new()
            {
                Type = "Middle School", Name = "Flight", Description = "Trim/Flights - pre-built gliders",
                StartDateTime = DateTime.Parse("04/20/2023 12:00"), EndDateTime = DateTime.Parse("04/20/2023 14:30"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "Flight", Description = "Semifinalist Construction", StartDateTime = DateTime.Parse("04/20/2023 19:00"),
                EndDateTime = DateTime.Parse("04/20/2023 20:00"), Location = "Ski Lodge"
            },
            new()
            {
                Type = "Middle School", Name = "Flight", Description = "Trim/Flights - semifinalists", StartDateTime = DateTime.Parse("04/21/2023 14:00"),
                EndDateTime = DateTime.Parse("04/21/2023 16:00"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "Forensic Technology", Description = "Testing", StartDateTime = DateTime.Parse("04/19/2023 17:00"),
                EndDateTime = DateTime.Parse("04/19/2023 21:00"), Location = "Sunburst"
            },
            new()
            {
                Type = "Middle School", Name = "Forensic Technology", Description = "Testing", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 11:00"), Location = "Snowflake"
            },
            new()
            {
                Type = "Middle School", Name = "Forensic Technology", Description = "Semi-finals", StartDateTime = DateTime.Parse("04/21/2023 13:00"),
                EndDateTime = DateTime.Parse("04/21/2023 16:00"), Location = "Chestnut"
            },
            new()
            {
                Type = "Middle School", Name = "Forensic Technology", Description = "Semi-finals - report write-up",
                StartDateTime = DateTime.Parse("04/21/2023 13:00"), EndDateTime = DateTime.Parse("04/21/2023 16:00"), Location = "Evergreen"
            },
            new()
            {
                Type = "Middle School", Name = "Foundations of Information Technology", Description = "Testing",
                StartDateTime = DateTime.Parse("04/19/2023 17:00"), EndDateTime = DateTime.Parse("04/19/2023 21:00"), Location = "Sunburst"
            },
            new()
            {
                Type = "Middle School", Name = "Foundations of Information Technology", Description = "Testing",
                StartDateTime = DateTime.Parse("04/20/2023 09:30"), EndDateTime = DateTime.Parse("04/20/2023 11:00"), Location = "Snowflake"
            },
            new()
            {
                Type = "Middle School", Name = "Inventions and Innovations", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Inventions and Innovations", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/20/2023 15:00"), EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Inventions and Innovations", Description = "Pick Up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Junior Solar Sprint", Description = "Check-in", StartDateTime = DateTime.Parse("04/20/2023 20:00"),
                EndDateTime = DateTime.Parse("04/20/2023 20:30"), Location = "Ski Lodge"
            },
            new()
            {
                Type = "Middle School", Name = "Junior Solar Sprint", Description = "Time Trials", StartDateTime = DateTime.Parse("04/21/2023 11:00"),
                EndDateTime = DateTime.Parse("04/21/2023 12:30"), Location = "Ski Lodge"
            },
            new()
            {
                Type = "Middle School", Name = "Junior Solar Sprint", Description = "Semi-finals", StartDateTime = DateTime.Parse("04/21/2023 14:00"),
                EndDateTime = DateTime.Parse("04/21/2023 15:30"), Location = "Ski Lodge"
            },
            new()
            {
                Type = "Middle School", Name = "Leadership Strategies", Description = "Sign-up", StartDateTime = DateTime.Parse("04/19/2023 18:00"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Online Sign Up"
            },
            new()
            {
                Type = "Middle School", Name = "Leadership Strategies", Description = "Contest", StartDateTime = DateTime.Parse("04/20/2023 13:00"),
                EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Laurel"
            },
            new()
            {
                Type = "Middle School", Name = "Leadership Strategies", Description = "Prep", StartDateTime = DateTime.Parse("04/20/2023 13:00"),
                EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Fox Den"
            },
            new()
            {
                Type = "Middle School", Name = "Mass Production", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Mass Production", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/20/2023 15:00"), EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Mass Production", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Mechanical Engineering", Description = "Drop-off", StartDateTime = DateTime.Parse("04/20/2023 18:30"),
                EndDateTime = DateTime.Parse("04/20/2023 19:30"), Location = "Evergreen"
            },
            new()
            {
                Type = "Middle School", Name = "Mechanical Engineering", Description = "Sign-up", StartDateTime = DateTime.Parse("04/20/2023 18:30"),
                EndDateTime = DateTime.Parse("04/20/2023 19:30"), Location = "Evergreen"
            },
            new()
            {
                Type = "Middle School", Name = "Mechanical Engineering", Description = "Contest", StartDateTime = DateTime.Parse("04/21/2023 08:30"),
                EndDateTime = DateTime.Parse("04/21/2023 11:00"), Location = "Exhibit Hall - Annex"
            },
            new()
            {
                Type = "Middle School", Name = "Medical Technology", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Medical Technology", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/20/2023 15:00"), EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Medical Technology", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Microcontroller Design", Description = "Drop-off", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Microcontroller Design", Description = "Presentations",
                StartDateTime = DateTime.Parse("04/20/2023 15:00"), EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Microcontroller Design", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Off the Grid", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Off the Grid", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/20/2023 15:00"), EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Off the Grid", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "Prepared Speech", Description = "Sign-up", StartDateTime = DateTime.Parse("04/19/2023 18:00"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Online Sign Up"
            },
            new()
            {
                Type = "Middle School", Name = "Prepared Speech", Description = "Contest", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 12:30"), Location = "Seasons #1"
            },
            new()
            {
                Type = "Middle School", Name = "Prepared Speech", Description = "Contest", StartDateTime = DateTime.Parse("04/20/2023 13:00"),
                EndDateTime = DateTime.Parse("04/20/2023 16:00"), Location = "Seasons #1"
            },
            new()
            {
                Type = "Middle School", Name = "Problem Solving", Description = "Contest", StartDateTime = DateTime.Parse("04/21/2023 13:30"),
                EndDateTime = DateTime.Parse("04/21/2023 17:30"), Location = "Ski Lodge - 2nd Floor"
            },
            new()
            {
                Type = "Middle School", Name = "Promotional Marketing", Description = "Semi-finals", StartDateTime = DateTime.Parse("04/21/2023 09:00"),
                EndDateTime = DateTime.Parse("04/21/2023 11:00"), Location = "Laurel"
            },
            new()
            {
                Type = "Middle School", Name = "STEM Animation", Description = "Semi-finalist Presentation",
                StartDateTime = DateTime.Parse("04/21/2023 09:00"), EndDateTime = DateTime.Parse("04/21/2023 12:00"), Location = "Ski Lodge - Foggy Brews"
            },
            new()
            {
                Type = "Middle School", Name = "Structural Engineering", Description = "Drop-off", StartDateTime = DateTime.Parse("04/20/2023 10:00"),
                EndDateTime = DateTime.Parse("04/20/2023 11:00"), Location = "Ski Lodge - Maple"
            },
            new()
            {
                Type = "Middle School", Name = "Structural Engineering", Description = "Testing", StartDateTime = DateTime.Parse("04/20/2023 14:00"),
                EndDateTime = DateTime.Parse("04/20/2023 00:00"), Location = "Ski Lodge - Maple"
            },
            new()
            {
                Type = "Middle School", Name = "Structural Engineering", Description = "Construction", StartDateTime = DateTime.Parse("04/20/2023 19:00"),
                EndDateTime = DateTime.Parse("04/20/2023 21:30"), Location = "Ski Lodge - Maple"
            },
            new()
            {
                Type = "Middle School", Name = "Structural Engineering", Description = "Testing", StartDateTime = DateTime.Parse("04/21/2023 10:00"),
                EndDateTime = DateTime.Parse("04/21/2023 12:00"), Location = "Ski Lodge - Maple"
            },
            new()
            {
                Type = "Middle School", Name = "System Control Technology", Description = "Contest", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 12:30"), Location = "Ski Lodge - 2nd Floor"
            },
            new()
            {
                Type = "Middle School", Name = "System Control Technology", Description = "Pick-up", StartDateTime = DateTime.Parse("04/20/2023 15:00"),
                EndDateTime = DateTime.Parse("04/20/2023 16:00"), Location = "Ski Lodge - 2nd Floor"
            },
            new()
            {
                Type = "Middle School", Name = "Tech Bowl", Description = "Testing", StartDateTime = DateTime.Parse("04/19/2023 17:00"),
                EndDateTime = DateTime.Parse("04/19/2023 21:00"), Location = "Sunburst"
            },
            new()
            {
                Type = "Middle School", Name = "Tech Bowl", Description = "Testing", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 11:00"), Location = "Snowflake"
            },
            new()
            {
                Type = "Middle School", Name = "Tech Bowl", Description = "Semi-finals", StartDateTime = DateTime.Parse("04/20/2023 17:30"),
                EndDateTime = DateTime.Parse("04/20/2023 20:00"), Location = "Sunburst"
            },
            new()
            {
                Type = "Middle School", Name = "Tech Bowl", Description = "Holding", StartDateTime = DateTime.Parse("04/20/2023 17:30"),
                EndDateTime = DateTime.Parse("04/20/2023 20:00"), Location = "Hemlock"
            },
            new()
            {
                Type = "Middle School", Name = "Technical Design", Description = "Directions", StartDateTime = DateTime.Parse("04/19/2023 20:00"),
                EndDateTime = DateTime.Parse("04/19/2023 20:15"), Location = "Laurel"
            },
            new()
            {
                Type = "Middle School", Name = "Technical Design", Description = "Entry submission", StartDateTime = DateTime.Parse("04/21/2023 08:30"),
                EndDateTime = DateTime.Parse("04/21/2023 09:30"), Location = "Online Submission"
            },
            new()
            {
                Type = "Middle School", Name = "Video Game Design", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/21/2023 09:00"), EndDateTime = DateTime.Parse("04/21/2023 12:00"), Location = "Ski Lodge - Foggy Brews"
            },
            new()
            {
                Type = "Middle School", Name = "Website Design", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/21/2023 09:00"), EndDateTime = DateTime.Parse("04/21/2023 12:00"), Location = "Ski Lodge - Foggy Brews"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Delta Dart", Description = "Construction", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 12:00"), Location = "Ski Lodge"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Delta Dart", Description = "Trim/Flights", StartDateTime = DateTime.Parse("04/20/2023 19:30"),
                EndDateTime = DateTime.Parse("04/20/2023 20:30"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Digital Video Challenge", Description = "Directions",
                StartDateTime = DateTime.Parse("04/19/2023 20:15"), EndDateTime = DateTime.Parse("04/19/2023 20:30"), Location = "Fox Den"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Digital Video Challenge", Description = "Entry submission",
                StartDateTime = DateTime.Parse("04/21/2023 08:30"), EndDateTime = DateTime.Parse("04/21/2023 09:30"), Location = "Online Submission"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Logo Design", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Logo Design", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Materials Process", Description = "Check-in", StartDateTime = DateTime.Parse("04/19/2023 18:30"),
                EndDateTime = DateTime.Parse("04/19/2023 20:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Materials Process", Description = "Semi-finalist Interviews",
                StartDateTime = DateTime.Parse("04/20/2023 15:00"), EndDateTime = DateTime.Parse("04/20/2023 18:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Materials Process", Description = "Pick-up", StartDateTime = DateTime.Parse("04/21/2023 17:30"),
                EndDateTime = DateTime.Parse("04/21/2023 19:00"), Location = "Winterberry"
            },
            new()
            {
                Type = "Middle School", Name = "PA - R/C Off-Road Racing", Description = "Check-in", StartDateTime = DateTime.Parse("04/20/2023 09:30"),
                EndDateTime = DateTime.Parse("04/20/2023 10:30"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "PA - R/C Off-Road Racing", Description = "Track Set-up",
                StartDateTime = DateTime.Parse("04/20/2023 19:00"), EndDateTime = DateTime.Parse("04/20/2023 20:00"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "PA - R/C Off-Road Racing", Description = "Races", StartDateTime = DateTime.Parse("04/21/2023 08:00"),
                EndDateTime = DateTime.Parse("04/21/2023 12:00"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "PA - R/C Off-Road Racing", Description = "Pick Up", StartDateTime = DateTime.Parse("04/21/2023 15:30"),
                EndDateTime = DateTime.Parse("04/21/2023 16:30"), Location = "Grand Ballroom"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Robotics", Description = "Set-up", StartDateTime = DateTime.Parse("04/20/2023 18:00"),
                EndDateTime = DateTime.Parse("04/20/2023 19:00"), Location = "Timberstone"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Robotics", Description = "Practice", StartDateTime = DateTime.Parse("04/20/2023 19:00"),
                EndDateTime = DateTime.Parse("04/20/2023 21:00"), Location = "Timberstone"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Robotics", Description = "Drop-off", StartDateTime = DateTime.Parse("04/21/2023 13:00"),
                EndDateTime = DateTime.Parse("04/21/2023 13:30"), Location = "Timberstone"
            },
            new()
            {
                Type = "Middle School", Name = "PA - Robotics", Description = "Competition", StartDateTime = DateTime.Parse("04/21/2023 14:00"),
                EndDateTime = DateTime.Parse("04/21/2023 16:00"), Location = "Timberstone"
            },
            new()
            {
                Type = "Middle School", Name = "PA-TSA VEX - MS", Description = "Competition", StartDateTime = DateTime.Parse("04/20/2023 18:00"),
                EndDateTime = DateTime.Parse("04/20/2023 21:00"), Location = "Timberstone"
            }
        };
    }

    public List<ConferenceEventGroupModel> GetConferenceEventGroups()
    {
        var conferenceEventGroupModels = new List<ConferenceEventGroupModel>();

        var conferenceEventModels = GenerateData();

        var conferenceEventDates = conferenceEventModels.Select(_ => _.StartDateTime.Date).Distinct();

        foreach (var conferenceEventDate in conferenceEventDates)
        {
            var conferenceEventGroupModel = new ConferenceEventGroupModel
            {
                Name = conferenceEventDate.ToString("dddd")
            };

            conferenceEventGroupModel
                .AddRange(conferenceEventModels
                    .Where(_ => _.StartDateTime.Date == conferenceEventDate)
                    .OrderBy(_ => _.StartDateTime)
                    .ThenBy(_ => _.Name));

            conferenceEventGroupModels.Add(conferenceEventGroupModel);
        }

        return conferenceEventGroupModels;
    }

    public List<ConferenceEventModel> GetConferenceEvents()
    {
        return GenerateData();
    }
}
