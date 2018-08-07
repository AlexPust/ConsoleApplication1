using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static class Functional
    {
        static List<Teatcher> Teachers = new List<Teatcher>();
        static List<Student> Students = new List<Student>();
        public static void CreateBasePersons()
        {
            Teachers.Add(new Teatcher("Sasha", "Karpenko", new DateTime(1975, 5, 19), "male", 123, 32, new List<string>() { "Mathematics", "Physics" }));
            Teachers.Add(new Teatcher("Oleg", "Gomilko", new DateTime(1983, 3, 13), "male", 69, 27, new List<string>() { "English" }));
            Teachers.Add(new Teatcher("Anna", "Tsugel", new DateTime(1988, 11, 26), "female", 976, 22, new List<string>() { "Geography", "Chemistry", }));
            Teachers.Add(new Teatcher("Sofi", "Zhantalai", new DateTime(1986, 7, 5), "female", 354, 24, new List<string>() { "Literature" }));

            Students.Add(new Student("Sasha", "Chop", new DateTime(1998, 2, 19), "male", 321, 87643, 3, 4.5));
            Students.Add(new Student("Igor", "Gromodyan", new DateTime(1999, 7, 15), "male", 654, 13412, 2, 3.2));
            Students.Add(new Student("Ulia", "Yatsura", new DateTime(1998, 5, 3), "female", 432, 97635, 3, 4));
            Students.Add(new Student("Petro", "Bendera", new DateTime(1999, 12, 2), "male", 31, 23422, 1, 4.4));
            Students.Add(new Student("Vika", "Slobodyan", new DateTime(1998, 9, 15), "female", 987, 32283, 3, 3.4));
            Students.Add(new Student("Vitaliy", "Minko", new DateTime(1997, 12, 9), "male", 32, 53445, 4, 4.7));
            Students.Add(new Student("Katya", "Levadna", new DateTime(1999, 5, 13), "female", 847, 49884, 2, 4.2));
            Students.Add(new Student("Viktor", "Siruy", new DateTime(2000, 2, 21), "male", 144, 33312, 1, 3.7));
            Students.Add(new Student("Sonya", "Dzis", new DateTime(1998, 3, 30), "female", 414, 47172, 3, 4.3));
            Students.Add(new Student("Andriy", "Shevchuk", new DateTime(2000, 7, 1), "male", 132, 12345, 1, 3.5));
        }
        public static void CreateNew(object value)
        {
            if (value is Teatcher)
            {
                Teachers.Add(new Teatcher());
                Teachers[Teachers.Count - 1].TeacherChangeInfo();
            }
            else
            if (value is Student)
            {
                Students.Add(new Student());
                Students[Students.Count - 1].StudentChangeInfo();
            }
            else throw new Exception("Wrong object type!");
        }
        public static void Delete(object value)
        {
            bool isDelete = false;
            Console.Write("Enter id:");
            int idDelete;
            idDelete = int.Parse(Console.ReadLine());
            if (value is Teatcher)
            {
                for (int i = 0; i < Teachers.Count(); i++)
                {
                    if (isDelete == true) break;
                    if (idDelete == Teachers[i].IdTeacher)
                    {
                        Console.Clear();
                        Console.WriteLine("Teather has been deleted!");
                        Teachers.Remove(Teachers[i]);
                        isDelete = true;
                    }
                }
            }
            else
            if (value is Student)
            {
                for (int i = 0; i < Students.Count(); i++)
                {
                    if (isDelete == true) break;
                    if (idDelete == Students[i].IdStudent)
                    {
                        Console.Clear();
                        Console.WriteLine("Student has been deleted!");
                        Students.Remove(Students[i]);
                        isDelete = true;
                    }
                }
            }
            else throw new Exception("Wrong object type!");
            if (isDelete == false) throw new Exception("Wrong info about id");
            Console.WriteLine("Press any key to go back!");
            Console.ReadLine();
        }
        public static void ShowInfo(object value)
        {
            bool isWasFoud = false;
            Console.Write("Enter id:");
            int id;
            id = int.Parse(Console.ReadLine());
            if (value is Teatcher)
            {
                for (int i = 0; i < Teachers.Count(); i++)
                {
                    if (isWasFoud == true) break;
                    if (id == Teachers[i].IdTeacher)
                    {
                        Console.Clear();
                        Teachers[i].TeacherShowInfo();
                        isWasFoud = true;
                    }
                }
            }
            else if(value is Student)
            {
                for (int i = 0; i < Students.Count(); i++)
                {
                    if (isWasFoud == true) break;
                    if (id == Students[i].IdStudent)
                    {
                        Console.Clear();
                        Students[i].StudentShowInfo();
                        isWasFoud = true;
                    }
                }
            }
            else throw new Exception("Wrong object type!");
            if (isWasFoud == false) throw new Exception("Wrong info about id");
            Console.WriteLine("Press any key to go back!");
            Console.ReadLine();
        }
        public static void ChangeInfo(object value)
        {
            bool isChange = false;
            Console.Write("Enter id:");
            int idChange;
            idChange = int.Parse(Console.ReadLine());
            if(value is Teatcher)
            {
                for (int i = 0; i < Teachers.Count(); i++)
                {
                    if (isChange == true) break;
                    if (idChange == Teachers[i].IdTeacher)
                    {
                        Console.Clear();
                        Teachers[i].TeacherChangeInfo();
                        Console.WriteLine("Teather has been changed!");
                        isChange = true;
                    }
                }
            }
            else if(value is Student)
            {
                for (int i = 0; i < Students.Count(); i++)
                {
                    if (isChange == true) break;
                    if (idChange == Students[i].IdStudent)
                    {
                        Console.Clear();
                        Students[i].StudentChangeInfo();
                        Console.WriteLine("Student has been changed!");
                        isChange = true;
                    }
                }
            }
            else throw new Exception("Wrong object type!");
            if (isChange == false) throw new Exception("Wrong info about id");
            Console.WriteLine("Press any key to go back!");
            Console.ReadLine();
        }
        public static void ShowSordetStudentsInfo()
        {
            Console.Clear();
            Student cont = new Student();
            Console.WriteLine("Information about all Students:");
            for (int j = 0; j < Students.Count(); j++)
            {
                for (int i = 0; i < Students.Count() - 1; i++)
                {
                    string str1, str2;
                    str1 = Students[i].Name;
                    str2 = Students[i + 1].Name;
                    if (str1.CompareTo(str2) > 0)
                    {
                        cont = Students[i];
                        Students[i] = Students[i + 1];
                        Students[i + 1] = cont;
                    }
                }
            }
            for (int i = 0; i < Students.Count() - 1; i++)
            {
                Students[i].StudentShowInfo();
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to go back!");
            Console.ReadLine();
        }
    }
}
