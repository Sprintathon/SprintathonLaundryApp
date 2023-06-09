using System;
using System.ComponentModel;

namespace SprintathonLaundryApp.Models
{
    public class Attendee
    {
        // The first name of the attendee
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Program { get; set; }
        public int Year { get; set; }
        public string Role { get; set; }
    }

    // A class that represents a sponsor of the event
    public class Sponsor
    {
        public string Name { get; set; }
        public string Logo { get; set; }
    }


}

