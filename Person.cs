using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
enum sex { male = 0, female = 1, none = 2 };
namespace ConsoleApplication1
{
    class Person
    {
        private string name { get; set; }
        public string Name {
            get
            {
                return name;
            }
        }
        private string surname { get; set; }
        private DateTime date { get; set; }
        private sex sexPerson;
     
        public Person()
        {
            name = null;
            surname = null;
            date = new DateTime();
            sexPerson = sex.none;
        }
        public Person(string _name,string _surname, DateTime _date, string _sex) 
        {
            name = _name; 
            surname = _surname;
            date = _date;
            if(_sex == "male")
            {
                sexPerson = sex.male;
            }
            if(_sex == "female")
            {
                sexPerson = sex.female;
            }
        }
        public void PersonShowInfo()
        {
            Console.Write("Name: ");
            Console.WriteLine(name);
            Console.Write("Surname: ");
            Console.WriteLine(surname);
            Console.Write("Date of birth: ");
            Console.WriteLine(date.ToShortDateString());
            Console.Write("Sex: ");
            Console.WriteLine(sexPerson);
        }
        public void PersonChangeInfo()
        {
            Console.Clear();
            Console.Write("Enter name:");
            name = Console.ReadLine();
            if (Regex.Match(name, @"[^a-zA-Z']").Success || name == "")
            {
                throw new Exception("Wrong info about name!");
            }
            Console.Write("Enter surname:");
            surname = Console.ReadLine();
            if (Regex.Match(surname, @"[^a-zA-Z']").Success || surname == "")
            {
                throw new Exception("Wrong info about surname!");
            }

            int day, month, year;
            Console.Write("Enter day of birth:");
            day = int.Parse(Console.ReadLine());
            if (day <= 0 || day > 31) throw new Exception("Wrong info about day!");
            Console.Write("Enter month of birth:");
            month = int.Parse(Console.ReadLine());
            if (month <= 0 || month > 12) throw new Exception("Wrong info about month!");
            Console.Write("Enter year of birth:");
            year = int.Parse(Console.ReadLine());
            if (year <= 0 || year > DateTime.Today.Year) throw new Exception("Wrong info about year!");
            date = new DateTime(year, month, day);

            Console.Write("Enter sex 0-male or 1-female):");
            bool sexInfo = bool.Parse(Console.ReadLine());
            if (sexInfo == true) sexPerson = sex.male;
            else if (sexInfo == false) sexPerson = sex.female;
            else throw new Exception("Wrong info about person sex");
        }
    }
}
