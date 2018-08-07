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
        private int idTeacher { get; set; }
        public int IdTeacher => idTeacher;
        private int experience { get; set; }
        private List<string> subj { get; set; }
        public Teatcher() : base()
        {
            idTeacher = 0;
            experience = 0;
            subj = new List<string>() { };
        }
        public Teatcher(string _name, string _surname, DateTime _date, string _sex, int _id, int _experience, List<string> _subj) : base(_name, _surname, _date, _sex)
        {
            idTeacher = _id;
            experience = _experience;
            subj = _subj;
        }
        public void TeacherChangeInfo()
        {
            bool isSetAllInformationOn = true;
            while (isSetAllInformationOn)
            {
                try
                {
                    
                    int id, exp, numb;
                    PersonChangeInfo();
                    
                    Console.Write("Enter id: ");
                    id = int.Parse(Console.ReadLine());
                    if (id < 0) throw new Exception("Wrong info about id!");

                    Console.Write("Enter expirience:");
                    exp = int.Parse(Console.ReadLine());
                    if (exp < 0) throw new Exception("Wrong info about expirience!");

                    Console.Write("Enter number of subjects:");
                    numb = int.Parse(Console.ReadLine());
                    if (numb < 0) throw new Exception("Wrong info about number of sublects!");
                    for (int i = 0; i < numb; i++)
                    {

                        string currentSubject;
                        Console.Write("Enter subject # {0}:", i + 1);
                        currentSubject = Console.ReadLine();
                        if (Regex.Match(currentSubject, @"[^a-zA-Z']").Success || currentSubject == "")
                        {
                            throw new Exception("Invalid info about subject!");
                        }
                        subj.Add(currentSubject);
                    }
                    idTeacher = id;
                    experience = exp;
                    isSetAllInformationOn = false;
                }
                catch (Exception exeption)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: " + exeption.Message);
                    Console.WriteLine("Для продолжения нажмите любую клавишу!");
                    Console.ReadLine();
                }

            }
        }
        public void TeacherShowInfo()
        {
                PersonShowInfo();
                Console.Write("Teacher id: ");
                Console.WriteLine(idTeacher);
                Console.Write("Teacher expirience: ");
                Console.WriteLine(experience);
                Console.WriteLine("Subjects:");
                for (int i = 0; i < subj.Count; i++)
                {
                    Console.WriteLine("\t" + subj[i]);
                }
        }

    }
}    

           
        
     