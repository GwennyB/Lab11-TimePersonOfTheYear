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
            larry.Name = "Larry";
            larry.Year = 2003;
            larry.Honor = "coolest cat";
            larry.Category = "cool peeps";
            TimePerson curly = new TimePerson();
            curly.Name = "Curly";
            curly.Year = 2003;
            curly.Honor = "curliest cat";
            curly.Category = "curly peeps";
            TimePerson moe = new TimePerson();
            moe.Name = "Moe";
            moe.Year = 2003;
            moe.Honor = "moest cat";
            moe.Category = "moe peeps";
            List<TimePerson> winners = new List<TimePerson>() { larry, curly, moe };

            // TODO: query data source, build objects, populate list

            return winners;
        }
    }
}
