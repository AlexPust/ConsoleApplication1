using System;
using System.Text.RegularExpressions;
enum gender { male = 0, female = 1, none = 2 };
namespace ConsoleApplication1
{
    class Person
    {
        private string name { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
        }
        private string surname { get; set; }
        protected DateTime date { get; set; }
        private gender genderPerson;
        public Person()
        {
            name = null;
            surname = null;
            date = new DateTime();
            genderPerson = gender.none;
        }
        public Person(string name, string surname, DateTime date, string genderPerson)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
            if (genderPerson == "male")
            {
                this.genderPerson = gender.male;
            }
            if (genderPerson == "female")
            {
                this.genderPerson = gender.female;
            }
        }
        public void PersonChangeInfo()
        {
            Console.Clear();
            Console.Write("Enter name:");
            name = Console.ReadLine();
            name.Trim();
            if (Regex.Match(name, @"[^a-zA-Z']").Success || name == "")
            {
                throw new Exception("Name have wrong symbols!");
            }
            if (name.Length > 15) throw new Exception("Name is too long!");
            Console.Write("Enter surname:");
            surname = Console.ReadLine();
            surname.Trim();
            if (Regex.Match(surname, @"[^a-zA-Z']").Success || surname == "")
            {
                throw new Exception("Surname have wrong symbols!");
            }
            if (surname.Length > 15) throw new Exception("Surname is too long!");
            int day, month, year;
            Console.Write("Enter day of birth:");
            if (int.TryParse(Console.ReadLine(), out day)) throw new Exception("Wrong info!");
            if (day <= 0 || day > 31) throw new Exception("Wrong info about day!");
            Console.Write("Enter month of birth:");
            if (int.TryParse(Console.ReadLine(), out month)) throw new Exception("Wrong info!");
            if (month <= 0 || month > 12) throw new Exception("Wrong info about month!");
            Console.Write("Enter year of birth:");
            if (int.TryParse(Console.ReadLine(), out year)) throw new Exception("Wrong info!");
            if (year <= DateTime.Today.Year - 150 || year > DateTime.Today.Year - 16) throw new Exception("Wrong info about year!");
            date = new DateTime(year, month, day);

            Console.Write("Enter gender (0-male or 1-female):");
            int genderInfo;
            if (int.TryParse(Console.ReadLine(), out genderInfo)) throw new Exception("Wrong info!");
            if (genderInfo == 0) genderPerson = gender.male;
            else if (genderInfo == 1) genderPerson = gender.female;
            else throw new Exception("Wrong info about person gender");
        }
        public override string ToString()
        {
            string output = String.Format("Name: {0}\nSurname: {1}\nDate of birth: {2}\nGender: {3}\n", name, surname, date.ToShortDateString(), genderPerson);
            return output;
        }
    }
}
