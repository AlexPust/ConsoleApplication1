using System;
using System.Text.RegularExpressions;
using static ConsoleApplication1.FunctionalPeople;

namespace ConsoleApplication1
{
    class Group
    {
        private string name { get; set; }
        private int curator { get; set; }
        public Group()
        {

            name = "";
            curator = 0;
        }
        public Group(string name, int curator)
        {

            this.name = name;
            this.curator = curator;
        }
        public void GroupChangeInfo()
        {
            Console.Clear();
            char[] charsToTrim = { ' ' };
            int curatorId;
            string nameGroup;
            FunctionalPeople functional = new FunctionalPeople();

            Console.Write("Enter group's name:");
            nameGroup = Console.ReadLine();
            nameGroup = nameGroup.Trim(charsToTrim);
            nameGroup = Regex.Replace(nameGroup, @"\s+", " ");
            if (Regex.Match(nameGroup, @"[^a-zA-Z' ]").Success || nameGroup == "")
            {
                throw new Exception("Wrong info about name!");
            }

            Console.Write("Enter curator's id:");
            if (int.TryParse(Console.ReadLine(), out curatorId)) throw new Exception("Wrong info!");
            if (curatorId > Teachers.Count || curatorId < 0) throw new Exception("Wrong info about curator's id!");
            name = nameGroup;
            curator = curatorId;
        }
        public override string ToString()
        {
            string output = String.Format("Name: {0}\nCurator's id: {1}\n", name, curator);
            return output;
        }
    }
}
