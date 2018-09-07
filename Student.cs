using System;
using static ConsoleApplication1.FunctionalUniversitet;

namespace ConsoleApplication1
{
    class Student : Person
    {
        private int number { get; set; }
        private int course { get; set; }
        private double averageScore { get; set; }
        private int idGroup { get; set; }
        public Student() : base()
        {
            number = 0;
            course = 0;
            averageScore = 0;
            idGroup = 0;
        }
        public Student(string name, string surname, DateTime date, string sex, int number, int course, double averageScore, int idGroup) : base(name, surname, date, sex)
        {
            this.number = number;
            this.course = course;
            this.averageScore = averageScore;
            this.idGroup = idGroup;
        }
        public void StudentChangeInfo()
        {
            int numb, cours, groupId;
            double studentsAvarageSore;
            PersonChangeInfo();
            Console.Write("Enter number of record-book:");
            if (int.TryParse(Console.ReadLine(), out numb)) throw new Exception("Wrong info!");
            if (numb < 0 || numb > 99999) throw new Exception("Wrong info about record-book!");

            Console.Write("Enter number of course:");
            if (int.TryParse(Console.ReadLine(), out cours)) throw new Exception("Wrong info!");
            if (cours < 0 || cours > 5) throw new Exception("Wrong info about course!\nNumber of course is large or small!");

            Console.Write("Enter average score:");
            if (double.TryParse(Console.ReadLine(), out studentsAvarageSore)) throw new Exception("Wrong info!");
            if (studentsAvarageSore < 0 || studentsAvarageSore > 5) throw new Exception("Wrong info about average score!");

            Console.Write("Enter group's id:");
            if (int.TryParse(Console.ReadLine(), out groupId)) throw new Exception("Wrong info!");
            if (groupId > Groups.Count || groupId < 0) throw new Exception("Wrong info about group's id!");

            number = numb;
            course = cours;
            averageScore = studentsAvarageSore;
            idGroup = groupId;
        }
        public override string ToString()
        {
            string output = String.Format(base.ToString() + "Number of student's record-book: {0}\nNumber of course: {1}\nStudent's average score: {2}\nGroup's id: {3}", number, course, averageScore, idGroup);
            return output;
        }
    }
}
