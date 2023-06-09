namespace SprintathonLaundryApp.ViewModels
{
	public partial class AboutViewModel :BaseViewModel
	{
        // The list of attendees of the event
        [ObservableProperty]
        private List<Attendee> attendees;

        // The list of sponsors of the event
        [ObservableProperty]
        private List<Sponsor> sponsors;

        // The constructor for the view model
        public AboutViewModel()
        {
            // Initialize the list of attendees with some sample data (you can replace it with your own data)
            Attendees = new List<Attendee>
            {
                 new Attendee { FirstName = "MAKAI", LastName = "MAKAI", Program = "CE", Year = 4, Role = "" },
                 new Attendee { FirstName = "BRIGHT", LastName = "KATONGO", Program = "CS", Year = 1, Role = "" },
                 new Attendee { FirstName = "MWANGANA. K", LastName = "MUMEKA", Program = "EEE", Year = 4, Role = "" },
                 new Attendee { FirstName = "MUBALA", LastName = "MAWERE", Program = "CE", Year = 1, Role = "" },
                 new Attendee { FirstName = "GIFT", LastName = "KAWAMWILU", Program = "CS", Year = 1, Role = "" },
                 new Attendee { FirstName = "ARTHUR", LastName = "MULOPA", Program = "CE", Year = 4, Role = "" },
                 new Attendee { FirstName = "PHILIMON", LastName = "KAMINGA", Program = "CS", Year = 4, Role = "" },
                 new Attendee { FirstName = "ITTAI", LastName = "TUMELO", Program = "CS", Year = 4, Role = "ORGANIZER" },
                 new Attendee { FirstName = "ISAAC .J", LastName = "ZIMBA", Program = "CS", Year = 2, Role = "ORGANIZER" },
                 new Attendee { FirstName = "CHOTA", LastName = "MULENGA", Program = "CS", Year = 3, Role = "" },
                 new Attendee { FirstName = "EMMANUEL M", LastName = "MUYAMBO", Program = "CE", Year = 3, Role = "" },
                 new Attendee { FirstName = "DINGSWAYO", LastName = "NKASHI", Program = "CE", Year = 2, Role = "" },
                 new Attendee { FirstName = "JEREMIAH", LastName = "NDALAMEI", Program = "CE", Year = 4, Role = "ORGANIZER" },
                 new Attendee { FirstName = "PULE", LastName = "CHOLA", Program = "CS", Year = 2, Role = "" },
                 new Attendee { FirstName = "MWEETWA M.", LastName = "NKETANI", Program = "CE", Year = 2, Role = "" },
                 new Attendee { FirstName = "CHIBWE", LastName = "MPHATSO", Program = "CS", Year = 2, Role = "" },
                 new Attendee { FirstName = "FIDELITY C.", LastName = "MULENGA", Program = "CS", Year = 4, Role = "" },
                 new Attendee { FirstName = "RENE", LastName = "IRASUBIZA", Program ="MECHATRONICS", Year=4, Role="" },
                 new Attendee { FirstName="MOONGA .H" ,LastName="KACHINDA" ,Program="CS" ,Year=4 ,Role="ORGANIZER"},
                 new Attendee { FirstName="CALEB" ,LastName="CHILUFYA" ,Program="CS" ,Year=2 ,Role=""},
                 new Attendee { FirstName="FREDRICK" ,LastName="MWEPU" ,Program="CE" ,Year=1 ,Role=""},
                new Attendee { FirstName="SEPO" ,LastName="KONAYUMA" ,Program="CS" ,Year=1 ,Role=""},
                 new Attendee { FirstName="MWIINGA" ,LastName="KAYUNI" ,Program="CS" ,Year=2 ,Role=""},
                 new Attendee { FirstName="LWANDO" ,LastName="KASUBA" ,Program="CS" ,Year=4 ,Role="ORGANIZER"},
                 new Attendee { FirstName="ISHA" ,LastName="CHILYOBWE" ,Program="CE" ,Year=2 ,Role=""},
                 new Attendee { FirstName="TANTHWE" ,LastName="MWANZA" ,Program="ARCHITECTURE" ,Year=1 ,Role=""},
                 new Attendee { FirstName="CHUMA" ,LastName="M'HANGO" ,Program="CE" ,Year=4 ,Role="ORGANIZER"},
                 new Attendee { FirstName="MWANSA M." ,LastName="MUKONKO" ,Program="CS" ,Year=4, Role=""}
             };

            // Initialize the list of sponsors with some sample data (you can replace it with your own data)
            Sponsors = new List<Sponsor>
             {
                 new Sponsor { Name ="The American Corner", Logo ="american_corner_logo.png"},
                 new Sponsor { Name ="Zambezi Digital", Logo ="zambezi_digital_logo.png"},
                 new Sponsor { Name ="Omnisport ", Logo ="omnisport_logo.png"}
             };
        }

    }
}

