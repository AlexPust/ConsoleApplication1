using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Teatcher : Person
    {
        private int idTeacher;
        private int experience;
        private List<string> subj;
        public Teatcher(): base()
        {
            idTeacher = 0;
            experience = 0;
            subj = new List<string>() { };
        }
        public Teatcher(string _name, string _surname, string _date, int _sex, int _id, int _experience, List<string> _subj) : base(_name, _surname, _date, _sex)
        {
            idTeacher = _id;
            experience = _experience;
            subj = _subj;
        }
        public void SetIdTeacher(int _id)
        {
            idTeacher = _id;
        }
        public void SetExperience(int _exp)
        {
            experience = _exp;
        }
        public void SetSubjects(List<string> _subj)
        {
            subj = _subj;
        }
        public List<string> GetSubjects()
        {
            return subj;
        }
        public int GetIdTeacher()
        {
            return idTeacher;
        }
        public int GetExperience()
        {
            return experience;
        }
        public void SetAllInformation()
        {
            bool isSetAllInformationOn = true;
            while (isSetAllInformationOn)
            {
                string name, surname, date = "";
                int sex, id, exp, numb;
                List<string> subj = new List<string>();

                Console.Write("Enter name:");
                name = Console.ReadLine();
                if (Regex.Match(name, @"[^a-zA-Z']").Success)
                {
                    Console.WriteLine("Incorrect info!");
                    continue;
                }
                Console.Write("Enter surname:");
                surname = Console.ReadLine();
                if (Regex.Match(surname, @"[^a-zA-Z']").Success)
                {
                    Console.WriteLine("Incorrect info!");
                    continue;
                }

                int day, month, year;
                Console.Write("Enter day:");
                day = int.Parse(Console.ReadLine());
                if (day <= 0 || day > 31) throw new Exception("Wrong info about day!");
                Console.Write("Enter month:");
                month = int.Parse(Console.ReadLine());
                if (month <= 0 || month > 12) throw new Exception("Wrong info about month!");
                Console.Write("Enter year:");
                year = int.Parse(Console.ReadLine());
                if (year <= 0 || year > DateTime.Today.Year) throw new Exception("Wrong info about year!");
                date = date + day.ToString() + '.' + month.ToString() + '.' + year.ToString();
                


                if (Regex.Match(surname, @"[^a-zA-Z']").Success)
                {
                    Console.WriteLine("Incorrect info!");
                    continue;
                }
            }
           

           
        
      /*  f3:
            Console.Write("Enter date of birth:");
            date = Console.ReadLine();
            if (date.Length == 0 || date.Length == 0 || date.Contains("!") || date.Contains("@") || date.Contains("#") || date.Contains("$") || date.Contains("%") || date.Contains("^") || date.Contains("&") || date.Contains("*") || date.Contains("(") || date.Contains(")") || date.Contains("_") || date.Contains("=") || date.Contains("+") || date.Contains("-") || date.Contains("/"))
            {
                Console.WriteLine("Incorrect info!");
                goto f3;
            }
        f4:
            Console.Write("Enter sex(0 - if male, 1 - if female):");
            try
            {
                sex = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect info!");
                goto f4;
            }
            if (sex < 0 || sex > 1)
            {
                Console.WriteLine("Incorrect info!");
                goto f4;
            }
        f5:
            Console.Write("Enter id:");
            try
            {
                id = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect info!");
                goto f5;
            }
            if (id < 0)
            {
                Console.WriteLine("Incorrect info!");
                goto f5;
            }
        f6:
            Console.Write("Enter expirience:");
            exp = int.Parse(Console.ReadLine());
            if (exp < 0)
            {
                Console.WriteLine("Incorrect info!");
                goto f6;
            }
        f7:
            Console.Write("Enter number of subjects:");
            numb = int.Parse(Console.ReadLine());
            if (numb < 0)
            {
                Console.WriteLine("Incorrect info!");
                goto f7;
            }
            for (int i = 0; i < numb; i++)
            {
            f8:
                string subj1;
                Console.Write("Enter subject # {0}:", i + 1);
                subj1 = Console.ReadLine();
                if (date.Length == 0 || subj1.Length == 0 || subj1.Contains("1") || subj1.Contains("2") || subj1.Contains("3") || subj1.Contains("4") || subj1.Contains("5") || subj1.Contains("6") || subj1.Contains("7") || subj1.Contains("8") || subj1.Contains("9") || subj1.Contains("0") || subj1.Contains("!") || subj1.Contains("@") || subj1.Contains("#") || subj1.Contains("$") || subj1.Contains("%") || subj1.Contains("^") || subj1.Contains("&") || subj1.Contains("*") || subj1.Contains("(") || subj1.Contains(")") || subj1.Contains("_") || subj1.Contains("=") || subj1.Contains("+") || subj1.Contains("-") || subj1.Contains("/"))
                {
                    Console.WriteLine("Incorrect info!");
                    goto f8;
                }
                subj.Add(subj1);
            }*/

    }
    }
}
