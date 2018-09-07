using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class FunctionalPeople : TFunctional
    {
        public static List<Teatcher> Teachers = new List<Teatcher>();
        public static List<Student> Students = new List<Student>();
        public void CreateBaseInfo()
        {
            Teachers.Add(new Teatcher("Sasha", "Karpenko", new DateTime(1975, 5, 19), "male", 32, new List<string>() { "Mathematics", "Physics" }));
            Teachers.Add(new Teatcher("Oleg", "Gomilko", new DateTime(1983, 3, 13), "male", 27, new List<string>() { "English" }));
            Teachers.Add(new Teatcher("Anna", "Tsugel", new DateTime(1988, 11, 26), "female", 22, new List<string>() { "Geography", "Chemistry", }));
            Teachers.Add(new Teatcher("Sofi", "Zhantalai", new DateTime(1986, 7, 5), "female", 24, new List<string>() { "Literature" }));

            Students.Add(new Student("Sasha", "Chop", new DateTime(1998, 2, 19), "male", 87643, 3, 4.5, 1));
            Students.Add(new Student("Igor", "Gromodyan", new DateTime(1999, 7, 15), "male", 13412, 2, 3.2, 1));
            Students.Add(new Student("Ulia", "Yatsura", new DateTime(1998, 5, 3), "female", 97635, 3, 4, 2));
            Students.Add(new Student("Petro", "Bendera", new DateTime(1999, 12, 2), "male", 23422, 1, 4.4, 3));
            Students.Add(new Student("Vika", "Slobodyan", new DateTime(1998, 9, 15), "female", 32283, 3, 3.4, 2));
            Students.Add(new Student("Vitaliy", "Minko", new DateTime(1997, 12, 9), "male", 53445, 4, 4.7, 3));
            Students.Add(new Student("Katya", "Levadna", new DateTime(1999, 5, 13), "female", 49884, 2, 4.2, 4));
            Students.Add(new Student("Viktor", "Siruy", new DateTime(2000, 2, 21), "male", 33312, 1, 3.7, 4));
            Students.Add(new Student("Sonya", "Dzis", new DateTime(1998, 3, 30), "female", 47172, 3, 4.3, 5));
            Students.Add(new Student("Andriy", "Shevchuk", new DateTime(2000, 7, 1), "male", 12345, 1, 3.5, 5));
        }
        public void Edit(object value)
        {
            Console.Write("Enter id:");
            int idChange;

            if (value is Teatcher)
            {
                if (Teachers.Count == 0)
                {
                    throw new Exception("List is empty!");
                }
                int.TryParse(Console.ReadLine(), out idChange);
                if (idChange < Teachers.Count)
                {
                    Console.Clear();
                    Teachers[idChange].TeacherChangeInfo();
                    Console.WriteLine("Teather has been changed!");
                }
                else throw new Exception("Wrong info about id");
            }
            else if (value is Student)
            {
                if (Students.Count == 0)
                {
                    throw new Exception("List is empty!");
                }
                idChange = int.Parse(Console.ReadLine());
                if (idChange < Students.Count)
                {
                    Console.Clear();
                    Students[idChange].StudentChangeInfo();
                    Console.WriteLine("Student has been changed!");
                }
                else throw new Exception("Wrong info about id");
            }
            else throw new Exception("Wrong object type!");
            Console.WriteLine("Press any key to go back!");
            Console.ReadKey();
        }
        public void ShowSordetStudentsInfo()
        {
            if (Students.Count == 0)
            {
                throw new Exception("List is empty!");
            }
            Console.Clear();
            Student studentCopy = new Student();
            Console.WriteLine("Information about all Students:");
            for (int j = 0; j < Students.Count(); j++)
            {
                for (int i = 0; i < Students.Count() - 1; i++)
                {
                    string nameStudent1, nameStudent2;
                    nameStudent1 = Students[i].Name;
                    nameStudent2 = Students[i + 1].Name;
                    if (nameStudent1.CompareTo(nameStudent2) > 0)
                    {
                        studentCopy = Students[i];
                        Students[i] = Students[i + 1];
                        Students[i + 1] = studentCopy;
                    }
                }
            }
            for (int i = 0; i < Students.Count() - 1; i++)
            {
                Console.WriteLine("Student's id: {0}\n" + Students[i].ToString(), i);

                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("Press any key to go back!");
            Console.ReadKey();
        }
        public void ShowAllInfo<T>(List<T> GenericList)
        {
            if (GenericList.Count == 0)
            {
                throw new Exception("List is empty!");
            }
            int i = 0;
            foreach (T t in GenericList)
            {
                Console.Write("Id: {0}\n" + t.ToString(), i++);
                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("Press any key to go back!");
            Console.ReadKey();
        }
        public void Add<T>(T value, List<T> GenericList)
        {
            int countOfObjects = GenericList.Count;
            GenericList.Add(value);
            if (GenericList.Count != countOfObjects)
            {
                Console.Clear();
                Console.WriteLine("Student has been created!");
                Console.WriteLine("Press any key to go back!");
                Console.ReadKey();
            }
        }
        public void Delete<T>(List<T> GenericList)
        {
            if (GenericList.Count == 0)
            {
                throw new Exception("List is empty!");
            }
            Console.Write("Enter id:");
            int idDelete;
            idDelete = int.Parse(Console.ReadLine());
            if (idDelete < GenericList.Count)
            {
                GenericList.Remove(GenericList[idDelete]);
                Console.Clear();
                Console.WriteLine("Deleted!");
            }
            else throw new Exception("Wrong info about id");
            Console.WriteLine("Press any key to go back!");
            Console.ReadKey();
        }
        public void ShowInfo<T>(List<T> GenericList)
        {
            if (GenericList.Count == 0)
            {
                throw new Exception("List is empty!");
            }
            Console.Write("Enter id:");
            int id;
            id = int.Parse(Console.ReadLine());
            if (id < GenericList.Count)
            {
                Console.Clear();
                Console.WriteLine("Id: {0}\n" + GenericList[id].ToString(), id);

            }
            else throw new Exception("Wrong info about id");
            Console.WriteLine("Press any key to go back!");
            Console.ReadKey();
        }
    }
}
