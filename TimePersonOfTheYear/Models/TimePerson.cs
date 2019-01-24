using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace TimePersonOfTheYear.Models
{
    public class TimePerson
    {
        private static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");

        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        /// <summary>
        /// requests data file contents (formatted), filters per user inputs, and returns filtered results
        /// </summary>
        /// <param name="startYear"> user entered year to start search </param>
        /// <param name="endYear"> user entered year to end search </param>
        /// <returns></returns>
        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            List<TimePerson> winners = MakePeople(ReadFile());
            var filtered = from winner in winners
                         where winner.Year >= startYear && winner.Year <= endYear
                         select winner;

            List<TimePerson> winnersInRange = new List<TimePerson>();
            foreach (TimePerson winner in filtered)
            {
                winnersInRange.Add(winner);
            }

            return winnersInRange;
        }

        /// <summary>
        /// Reads in the data file and extracts into an array
        /// </summary>
        /// <returns> array containing data file contents (each element is a string with all data for single winner) </returns>
        private static string[] ReadFile()
        {
            string[] rawData = File.ReadAllLines(path);
            return rawData;
        }

        /// <summary>
        /// Accepts data file contents (in array of strings) and converts to TimePerson objects in a list
        /// </summary>
        /// <param name="data"> data file contents (in array of strings) </param>
        /// <returns> List of TimePerson objects (made from data file contents) </returns>
        private static List<TimePerson> MakePeople(string[] data)
        {
            List<TimePerson> people = new List<TimePerson>();
            for (int i = 1; i < data.Length; i++)
            {
                string[] rawPerson = data[i].Split(',');

                TimePerson person = new TimePerson();
                person.Year = int.TryParse(rawPerson[0], out int _) ? Convert.ToInt16(rawPerson[0]) : 0;
                person.Honor = rawPerson[1];
                person.Name = rawPerson[2];
                person.Country = rawPerson[3];
                person.BirthYear = int.TryParse(rawPerson[4],out int _) ? Convert.ToInt16(rawPerson[4]) : 0;
                person.DeathYear = int.TryParse(rawPerson[5], out int _) ? Convert.ToInt16(rawPerson[5]) : 0;
                person.Title = rawPerson[6];
                person.Category = rawPerson[7];
                person.Context = rawPerson[8];
                people.Add(person);
            }
            return people;
        }
    }
}
