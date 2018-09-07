using System;
using static ConsoleApplication1.FunctionalPeople;
using static ConsoleApplication1.FunctionalUniversitet;
enum day { Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday = 5, Sunday = 6, none = 7 }
namespace ConsoleApplication1
{
    class Curriculum
    {
        private int idTeacher { get; set; }
        private int idSubject { get; set; }
        private int idGroup { get; set; }
        private int numberLesson { get; set; }
        private day weekDay;
        public Curriculum()
        {

            idTeacher = 0;
            idSubject = 0;
            idGroup = 0;
            numberLesson = 0;
            weekDay = day.none;
        }
        public Curriculum(int idTeacher, int idSubject, int idGroup, int numberLesson, int weekDay)
        {

            this.idTeacher = idTeacher;
            this.idSubject = idSubject;
            this.idGroup = idGroup;
            this.numberLesson = numberLesson;
            if (weekDay < 0 || weekDay > 7) this.weekDay = day.none;
            if (weekDay == 1)
            {
                this.weekDay = day.Monday;
            }
            if (weekDay == 2)
            {
                this.weekDay = day.Tuesday;
            }
            if (weekDay == 3)
            {
                this.weekDay = day.Wednesday;
            }
            if (weekDay == 4)
            {
                this.weekDay = day.Thursday;
            }
            if (weekDay == 5)
            {
                this.weekDay = day.Friday;
            }
            if (weekDay == 6)
            {
                this.weekDay = day.Saturday;
            }
            if (weekDay == 7)
            {
                this.weekDay = day.Sunday;
            }
        }
        public void CurriculumChangeInfo()
        {
            int teacherId, subjectId, groupId, lessonNumber, days;
            Console.Write("Enter teacher's id:");
            if (int.TryParse(Console.ReadLine(), out teacherId)) throw new Exception("Wrong info!");
            if (teacherId > Teachers.Count || teacherId < 0) throw new Exception("Wrong info about teacher's id!");

            Console.Write("Enter subject's id:");
            if (int.TryParse(Console.ReadLine(), out subjectId)) throw new Exception("Wrong info!");
            if (subjectId > Subjects.Count || subjectId < 0) throw new Exception("Wrong info about subject's id!");

            Console.Write("Enter group's id:");
            if (int.TryParse(Console.ReadLine(), out groupId)) throw new Exception("Wrong info!");
            if (groupId > Groups.Count || groupId < 0) throw new Exception("Wrong info about group's id!");

            Console.Write("Enter lesson's number:");
            if (int.TryParse(Console.ReadLine(), out lessonNumber)) throw new Exception("Wrong info!");
            if (lessonNumber < 0 || lessonNumber > 7) throw new Exception("Wrong info about lesson's number!");

            Console.Write("Number of days:\n\t1-Monday\n\t2-Tuesday\n\t3-Wednesday\n\t4-Thursday\n\t5-Friday\n\t6-Saturday\n\t7-Sunday\nEnter day:");
            if (int.TryParse(Console.ReadLine(), out days)) throw new Exception("Wrong info!");
            if (days == 1)
            {
                weekDay = day.Monday;
            }
            else if (days == 2)
            {
                weekDay = day.Tuesday;
            }
            else if (days == 3)
            {
                weekDay = day.Wednesday;
            }
            else if (days == 4)
            {
                weekDay = day.Thursday;
            }
            else if (days == 5)
            {
                weekDay = day.Friday;
            }
            else if (days == 6)
            {
                weekDay = day.Saturday;
            }
            else if (days == 7)
            {
                weekDay = day.Sunday;
            }
            else throw new Exception("Wrong info about day!");

            idTeacher = teacherId;
            idSubject = subjectId;
            idGroup = groupId;
            numberLesson = lessonNumber;
        }
        public override string ToString()
        {
            string output = string.Format("Teacher's id: {0}\nSubject's id: {1}\nGroup's id: {2}\nLesson's number: {3}\nDay: {4}\n", idTeacher, idSubject, idGroup, numberLesson, weekDay);
            return output;
        }
    }
}
