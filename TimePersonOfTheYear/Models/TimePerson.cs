using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TimePersonOfTheYear.Models
{
    public class TimePerson
    {
        private static string path = Environment.CurrentDirectory;
        private static string fullPath = Path.GetFullPath(Path.Combine(path, @"personOfTheYear.csv"));



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
            //TimePerson larry = new TimePerson();
            //larry.Name = "Larry";
            //larry.Year = 2003;
            //larry.Honor = "coolest cat";
            //larry.Category = "cool peeps";
            //TimePerson curly = new TimePerson();
            //curly.Name = "Curly";
            //curly.Year = 2003;
            //curly.Honor = "curliest cat";
            //curly.Category = "curly peeps";
            //TimePerson moe = new TimePerson();
            //moe.Name = "Moe";
            //moe.Year = 2003;
            //moe.Honor = "moest cat";
            //moe.Category = "moe peeps";
            List<TimePerson> winners = MakePeople(ReadFile());

            // TODO: query data source, build objects, populate list

            return winners;
        }

        private static string[] ReadFile()
        {
            string[] rawData = File.ReadAllLines(fullPath);
            return rawData;
        }

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
