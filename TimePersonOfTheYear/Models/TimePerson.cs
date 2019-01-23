using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimePersonOfTheYear.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            TimePerson larry = new TimePerson();
            TimePerson curly = new TimePerson();
            TimePerson moe = new TimePerson();
            List<TimePerson> winners = new List<TimePerson>() { larry, curly, moe };

            // TODO: query data source, build objects, populate list

            return winners;
        }
    }
}
