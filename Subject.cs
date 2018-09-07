using System;
using System.Text.RegularExpressions;
namespace ConsoleApplication1
{
    class Subject
    {
        private string name { get; set; }
        public Subject()
        {
            name = "";
        }
        public Subject(string name)
        {
            this.name = name;
        }
        public void SubjectChangeInfo()
        {
            char[] charsToTrim = { ' ' };
            string nameSubject;
            Console.Write("Enter Subject's name:");
            nameSubject = Console.ReadLine();
            nameSubject = nameSubject.Trim(charsToTrim);
            nameSubject = Regex.Replace(nameSubject, @"\s+", " ");
            if (Regex.Match(nameSubject, @"[^a-zA-Z' ]").Success || nameSubject == "")
            {
                throw new Exception("Name have wrong symbols!");
            }
            if (nameSubject.Length > 25) throw new Exception("Subject's name is too long!");
            name = nameSubject;
        }
        public override string ToString()
        {
            string output = String.Format("Name: {0}\n", name);
            return output;
        }
    }
}
