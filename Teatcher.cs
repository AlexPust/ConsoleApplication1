using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Teatcher : Person
    {
        private int experience { get; set; }
        private List<string> subj { get; set; }
        public Teatcher() : base()
        {
            experience = 0;
            subj = new List<string>() { };
        }
        public Teatcher(string name, string surname, DateTime date, string sex, int experience, List<string> subj) : base(name, surname, date, sex)
        {

            this.experience = experience;
            this.subj = subj;
        }
        public void TeacherChangeInfo()
        {
            int exp, number;
            PersonChangeInfo();
            Console.Write("Enter expirience:");
            if (int.TryParse(Console.ReadLine(), out exp)) throw new Exception("Wrong info!");
            if (exp < 0 || exp > DateTime.Now.Year - date.Year + 16) throw new Exception("Wrong info about expirience!");
            Console.Write("Enter number of subjects:");
            if (int.TryParse(Console.ReadLine(), out number)) throw new Exception("Wrong info!");
            if (number < 0 || number > 5) throw new Exception("Wrong info about number of subjects!\nNumber of subjects is large or small");
            for (int i = 0; i < number; i++)
            {
                string currentSubject;
                Console.Write("Enter subject # {0}:", i + 1);
                currentSubject = Console.ReadLine();
                if (Regex.Match(currentSubject, @"[^a-zA-Z']").Success || currentSubject == "")
                {
                    throw new Exception("Invalid info about subject!");
                }
                if (currentSubject.Length > 25) throw new Exception("Subject's name is too long!");
                subj.Add(currentSubject);
            }
            experience = exp;
        }

        public override string ToString()
        {
            string subjects = "\n";
            for (int i = 0; i < subj.Count; i++)
            {
                subjects += "\t-" + subj[i] + "\n";
            }
            string output = String.Format(base.ToString() + "Teacher expirience: {0}\nSubjects: {1}", experience, subjects);
            return output;
        }
    }
}



