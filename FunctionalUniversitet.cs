using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class FunctionalUniversitet:TFunctional
    {
        public static List<Group> Groups = new List<Group>();
        public static List<Subject> Subjects = new List<Subject>();
        public static List<Curriculum> Curriculums = new List<Curriculum>();
        public void CreateBaseInfo()
        {
            Groups.Add(new Group("Group 1", 1));
            Groups.Add(new Group("Group 2", 2));
            Groups.Add(new Group("Group 3", 3));
            Groups.Add(new Group("Group 4", 1));
            Groups.Add(new Group("Group 5", 4));

            Subjects.Add(new Subject("Mathematic"));
            Subjects.Add(new Subject("English"));

            Curriculums.Add(new Curriculum(0,0,0,1,1));
        }
        public void Add<T>(T value, List<T> GenericList)
        {
            GenericList.Add(value);
        }
        public void Delete<T>(List<T> GenericList)
        {
            if(GenericList.Count == 0)
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
                Console.WriteLine("Id: {0}" + GenericList[id].ToString(), id);

            }
            else throw new Exception("Wrong info about id");
            Console.WriteLine("Press any key to go back!");
            Console.ReadKey();
        }
        public void Edit(object value)
        {
            Console.Write("Enter id:");
            int idChange;
           
            if (value is Group)
            {
                if (Groups.Count == 0)
                {
                    throw new Exception("List is empty!");
                }
                idChange = int.Parse(Console.ReadLine());
                if (idChange < Groups.Count)
                {
                    Console.Clear();
                    Groups[idChange].GroupChangeInfo();
                    Console.WriteLine("Group has been changed!");
                }
                else throw new Exception("Wrong info about id");
            }
            else
           if (value is Subject)
            {
                if (Subjects.Count == 0)
                {
                    throw new Exception("List is empty!");
                }
                idChange = int.Parse(Console.ReadLine());
                if (idChange < Subjects.Count)
                {
                    Console.Clear();
                    Subjects[idChange].SubjectChangeInfo();
                    Console.WriteLine("Subject has been changed!");
                }
                else throw new Exception("Wrong info about id");
            }
            else if (value is Curriculum)
            {
                if (Curriculums.Count == 0)
                {
                    throw new Exception("List is empty!");
                }
                idChange = int.Parse(Console.ReadLine());
                if (idChange < Curriculums.Count)
                {
                    Console.Clear();
                    Curriculums[idChange].CurriculumChangeInfo();
                    Console.WriteLine("Curriculum has been changed!");
                }
                else throw new Exception("Wrong info about id");
            }
            else throw new Exception("Wrong object type!");
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
    }
}
