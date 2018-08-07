using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student: Person
    {
        private int idStudents;
        public int IdStudent => idStudents;
        private int number { get; set; }
        private int course { get; set; }
        private double averageScore { get; set; }
        public Student(): base()
        {
            idStudents = 0;
            number = 0;
            course = 0;
            averageScore = 0;
        }
        public Student(string _name, string _surname, DateTime _date, string _sex, int id, int number,int course, double _score) : base(_name, _surname, _date, _sex)
        {
            idStudents = id;
            this.number = number;
            this.course = course;
            averageScore = _score;
        }
        public void StudentChangeInfo()
        {
            bool isSetAllInformationOn = true;
            while (isSetAllInformationOn)
            {
                try
                {
                    int id, numb, cours;
                    double avSore;
                    PersonChangeInfo();

                    Console.Write("Enter id: ");
                    id = int.Parse(Console.ReadLine());
                    if (id < 0) throw new Exception("Wrong info about id!");

                    Console.Write("Enter number of record-book:");
                    numb = int.Parse(Console.ReadLine());
                    if (numb < 0) throw new Exception("Wrong info about record-book!");

                    Console.Write("Enter number of course:");
                    cours = int.Parse(Console.ReadLine());
                    if (cours < 0) throw new Exception("Wrong info about course!");

                    Console.Write("Enter average score:");
                    avSore = double.Parse(Console.ReadLine());
                    if (avSore < 0 || avSore > 5) throw new Exception("Wrong info about average score!");

                    number = numb;
                    idStudents = id;
                    course = cours;
                    averageScore = avSore;
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
        public void StudentShowInfo()
        {
            PersonShowInfo();
            Console.Write("Student's id: ");
            Console.WriteLine(idStudents);
            Console.Write("Number of student's record-book: ");
            Console.WriteLine(number);
            Console.Write("Number of course: ");
            Console.WriteLine(course);
            Console.Write("Student's average score: ");
            Console.WriteLine(averageScore);
        }
    }
}
