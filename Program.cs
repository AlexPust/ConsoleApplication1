using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {
        public static bool IsString(string str)
        {
            if (Regex.Match(str, @"[^a-zA-Z']").Success)
            {
                return true;
            }
            else return false;
        }

        public static Teatcher CreateTeacher()
        {
            string name,surname,date;
            int sex, id, exp, numb;
            List<string> subj = new List<string>();
        f1:
            Console.Write("Enter name:");
            name = Console.ReadLine();
            if(IsString(name))
            {
                Console.WriteLine("Incorrect info!");
                goto f1;
            }
            f2:
            Console.Write("Enter surname:");
            surname = Console.ReadLine();
            if (IsString(surname))
            {
                Console.WriteLine("Incorrect info!");
                goto f2;
            }
            f3:
            Console.Write("Enter date of birth:");
            date = Console.ReadLine();
            if (date.Length == 0 || date.Length == 0 || date.Contains("!") || date.Contains("@") || date.Contains("#") || date.Contains("$") || date.Contains("%") || date.Contains("^") || date.Contains("&") || date.Contains("*") || date.Contains("(") || date.Contains(")") || date.Contains("_") || date.Contains("=") || date.Contains("+") || date.Contains("-") || date.Contains("/"))
            {
                Console.WriteLine("Incorrect info!");
                goto f3;
            }
        f4:
            Console.Write("Enter sex(0 - if male, 1 - if female):");
            try
            {
                sex = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect info!");
                goto f4;
            }
            if(sex <0 || sex > 1)
            {
                Console.WriteLine("Incorrect info!");
                goto f4;
            }
        f5:
            Console.Write("Enter id:");
            try
            {
                id = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect info!");
                goto f5;
            }
            if (id < 0)
            {
                Console.WriteLine("Incorrect info!");
                goto f5;
            }
        f6:
            Console.Write("Enter expirience:");
            exp = int.Parse(Console.ReadLine());
            if (exp < 0 )
            {
                Console.WriteLine("Incorrect info!");
                goto f6;
            }
            f7:
            Console.Write("Enter number of subjects:");
            numb = int.Parse(Console.ReadLine());
            if (numb < 0)
            {
                Console.WriteLine("Incorrect info!");
                goto f7;
            }
            for(int i = 0; i < numb; i++)
            {
                f8:
                string subj1;
                Console.Write("Enter subject # {0}:",i+1);
                subj1 = Console.ReadLine();
                if (date.Length == 0 || subj1.Length == 0 || subj1.Contains("1") || subj1.Contains("2") || subj1.Contains("3") || subj1.Contains("4") || subj1.Contains("5") || subj1.Contains("6") || subj1.Contains("7") || subj1.Contains("8") || subj1.Contains("9") || subj1.Contains("0") || subj1.Contains("!") || subj1.Contains("@") || subj1.Contains("#") || subj1.Contains("$") || subj1.Contains("%") || subj1.Contains("^") || subj1.Contains("&") || subj1.Contains("*") || subj1.Contains("(") || subj1.Contains(")") || subj1.Contains("_") || subj1.Contains("=") || subj1.Contains("+") || subj1.Contains("-") || subj1.Contains("/"))
                {
                    Console.WriteLine("Incorrect info!");
                    goto f8;
                }
                subj.Add(subj1);
            }
            
            Teatcher createTeacher = new Teatcher(name,surname,date,sex,id,exp,subj);
            return createTeacher;
        }

        public static Student CreateStudent()
        {
            string name, surname, date;
            int sex, id, number, course;
            double avaregscore;
        f1:
            Console.Write("Enter name:");
            name = Console.ReadLine();
            if (name.Length == 0 || name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9") || name.Contains("0") || name.Contains("!") || name.Contains("@") || name.Contains("#") || name.Contains("$") || name.Contains("%") || name.Contains("^") || name.Contains("&") || name.Contains("*") || name.Contains("(") || name.Contains(")") || name.Contains("_") || name.Contains("=") || name.Contains("+") || name.Contains("-") || name.Contains("/"))
            {
                Console.WriteLine("Incorrect info!");
                goto f1;
            }
        f2:
            Console.Write("Enter surname:");
            surname = Console.ReadLine();
            if (surname.Length == 0 || surname.Length == 0 || surname.Contains("1") || surname.Contains("2") || surname.Contains("3") || surname.Contains("4") || surname.Contains("5") || surname.Contains("6") || surname.Contains("7") || surname.Contains("8") || surname.Contains("9") || surname.Contains("0") || surname.Contains("!") || surname.Contains("@") || surname.Contains("#") || surname.Contains("$") || surname.Contains("%") || surname.Contains("^") || surname.Contains("&") || surname.Contains("*") || surname.Contains("(") || surname.Contains(")") || surname.Contains("_") || surname.Contains("=") || surname.Contains("+") || surname.Contains("-") || surname.Contains("/"))
            {
                Console.WriteLine("Incorrect info!");
                goto f2;
            }
        f3:
            Console.Write("Enter date of birth:");
            date = Console.ReadLine();
            if (date.Length == 0 || date.Length == 0 || date.Contains("!") || date.Contains("@") || date.Contains("#") || date.Contains("$") || date.Contains("%") || date.Contains("^") || date.Contains("&") || date.Contains("*") || date.Contains("(") || date.Contains(")") || date.Contains("_") || date.Contains("=") || date.Contains("+") || date.Contains("-") || date.Contains("/"))
            {
                Console.WriteLine("Incorrect info!");
                goto f3;
            }
        f4:
            Console.Write("Enter sex(0 - if male, 1 - if female):");
            sex = int.Parse(Console.ReadLine());
            if (sex < 0 || sex > 1)
            {
                Console.WriteLine("Incorrect info!");
                goto f4;
            }
        f5:
            Console.Write("Enter id:");
            id = int.Parse(Console.ReadLine());
            if (id < 0)
            {
                Console.WriteLine("Incorrect info!");
                goto f5;
            }
        f6:
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Incorrect info!");
                goto f6;
            }
        f7:
            Console.Write("Enter course:");
            course = int.Parse(Console.ReadLine());
            if (course < 1 || course > 5)
            {
                Console.WriteLine("Incorrect info!");
                goto f7;
            }
        f8:
            Console.Write("Enter avarage score:");
            avaregscore = double.Parse(Console.ReadLine());
            if (avaregscore < 0 || avaregscore > 5)
            {
                Console.WriteLine("Incorrect info!");
                goto f8;
            }

            Student createStudent = new Student(name, surname, date, sex, id, number, course, avaregscore );
            return createStudent;
        }


        static void Main(string[] args)
        {

            List<Teatcher> Teachers = new List<Teatcher>();
            List<Student> Students = new List<Student>();
       
            Teachers.Add(new Teatcher("Sasha", "Karpenko", "9.05.1979", 0, 123, 32, new List<string>() { "Mathematics", "Physics" }));
            Teachers.Add(new Teatcher("Oleg", "Gomilko", "13.03.1983", 0, 69, 27, new List<string>() { "English" }));
            Teachers.Add(new Teatcher("Anna", "Tsugel", "26.11.1988", 1, 976, 22, new List<string>() { "Geography", "Chemistry", }));
            Teachers.Add(new Teatcher("Sofi", "Zhantalai", "5.07.1986", 1, 354, 24, new List<string>() { "Literature" }));

            Students.Add(new Student("Sasha", "Chop", "19.02.1998", 0, 321, 87643, 3, 4.5));
            Students.Add(new Student("Igor", "Gromodyan", "15.06.1999", 0, 654, 13412, 2, 3.2));
            Students.Add(new Student("Ulia", "Yatsura", "3.05.1998", 1, 432, 97635, 3, 4));
            Students.Add(new Student("Petro", "Bendera", "2.12.2000", 0, 31, 23422, 1, 4.4));
            Students.Add(new Student("Vika", "Slobodyan", "15.09.1998", 1, 987, 32283, 3, 3.4));
            Students.Add(new Student("Vitaliy", "Minko", "9.12.1997", 0, 32, 53445, 4, 4.7));
            Students.Add(new Student("Katya", "Levadna", "3.05.1999", 1, 847, 49884, 2, 4.2));
            Students.Add(new Student("Viktor", "Siruy", "21.02.2000", 0, 144, 33312, 1, 3.7));
            Students.Add(new Student("Sonya", "Dzis", "30.03.1998", 1, 414, 47172, 3, 4.3));
            Students.Add(new Student("Andriy", "Shevchuk", "1.07.2000", 0, 132, 12345, 1, 3.5));

            bool programOn = true;
            while (programOn)
            {
                try {
                    Console.Clear();

                    byte numberOfChoise = 0;
                    Console.WriteLine("Select an action number:");
                    Console.WriteLine("1.Create person");
                    Console.WriteLine("2.Delete person");
                    Console.WriteLine("3.Show information about person");
                    Console.WriteLine("4.Change information");
                    Console.WriteLine("5.Show info about all Students");
                    Console.WriteLine("6.Exit");
                    Console.Write("Type the number:");
                    numberOfChoise = byte.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (numberOfChoise)
                    {
                        case 1:
                            Teachers.Add(new Teatcher());
                            Teachers[Teachers.Count-1].SetAllInformation();
                            break;
                        case 2:
                        case 3:
                            bool InfoProgranOn = true;
                            byte numberOfChoiseInInfo = 0;
                            while (InfoProgranOn)
                            {

                                Console.WriteLine("Select an action number:");
                                Console.WriteLine("1.Info about Teacher");
                                Console.WriteLine("2.Info about Student");
                                Console.WriteLine("3.Back");
                                Console.Write("Type the number:");
                                numberOfChoiseInInfo = byte.Parse(Console.ReadLine());
                                switch (numberOfChoiseInInfo)
                                {
                                    case 1:

                                        bool isTeacherWasFoud = false;
                                        Console.Write("Enter id:");
                                        int idTeacher;
                                        idTeacher = int.Parse(Console.ReadLine());

                                        for (int i = 0; i < Teachers.Count(); i++)
                                        {
                                            if (Teachers[i].GetIdTeacher() == idTeacher)
                                            {
                                                Console.Clear();
                                                isTeacherWasFoud = true;
                                                Console.Write("Name:");
                                                Console.WriteLine(Teachers[i].GetName());
                                                Console.Write("Surname:");
                                                Console.WriteLine(Teachers[i].GetSurname());
                                                Console.Write("Date of birth:");
                                                Console.WriteLine(Teachers[i].GetDate());
                                                Console.Write("Sex:");
                                                if (Teachers[i].GetSexPerson() == 0)
                                                {
                                                    Console.WriteLine("Male");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Female");
                                                }
                                                Console.Write("Id:");
                                                Console.WriteLine(Teachers[i].GetIdTeacher());
                                                Console.Write("Experience:");
                                                Console.WriteLine(Teachers[i].GetExperience());
                                                Console.Write("Subjects:");
                                                foreach (var name in Teachers[i].GetSubjects())
                                                    Console.Write(name + " ");
                                                Console.WriteLine("Press any key to go back!");
                                                Console.ReadLine();
                                            }

                                        }
                                        if (isTeacherWasFoud == false)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong id!!!");
                                            goto case 1;
                                        }
                                        break;

                                    case 2:

                                        bool isStudentWasFound = false;
                                        Console.Write("Enter id:");
                                        int idStudent;
                                        idStudent = int.Parse(Console.ReadLine());
                                        for (int i = 0; i < Students.Count(); i++)
                                        {
                                            if (Students[i].GetIdStudents() == idStudent)
                                            {
                                                Console.Clear();
                                                isStudentWasFound = true;
                                                Console.Write("Name:");
                                                Console.WriteLine(Students[i].GetName());
                                                Console.Write("Surname:");
                                                Console.WriteLine(Students[i].GetSurname());
                                                Console.Write("Date of birth:");
                                                Console.WriteLine(Students[i].GetDate());
                                                Console.Write("Sex:");
                                                if (Students[i].GetSexPerson() == 0)
                                                {
                                                    Console.WriteLine("Male");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Female");
                                                }
                                                Console.Write("Id:");
                                                Console.WriteLine(Students[i].GetIdStudents());
                                                Console.Write("Number:");
                                                Console.WriteLine(Students[i].GetNumbre());
                                                Console.Write("Course:");
                                                Console.WriteLine(Students[i].GetCourse());
                                                Console.Write("Avarage score:");
                                                Console.WriteLine(Students[i].GetAverageScore());
                                                Console.WriteLine("Press any key to go back!");
                                                Console.ReadLine();
                                            }

                                        }
                                        if (isStudentWasFound == false)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wrong id!!!");
                                            goto case 2;
                                        }
                                        break;
                                    case 3:
                                        Console.Clear();
                                        InfoProgranOn = false;
                                        break;
                                    default:
                                        Console.Clear();
                                        continue;

                                }


                                break;
                            }
                           

                            break;


                        case 4:
                        case 5:
                            Console.Clear();
                            Student cont = new Student();
                            Console.WriteLine("Information about all Students:");
                            for (int j = 0; j < Students.Count(); j++)
                            {
                                for (int i = 0; i < Students.Count() - 1; i++)
                                {
                                    string str1, str2;
                                    str1 = Students[i].GetName();
                                    str2 = Students[i + 1].GetName();
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
                                Console.Write("Name:");
                                Console.WriteLine(Students[i].GetName());
                                Console.Write("Surname:");
                                Console.WriteLine(Students[i].GetSurname());
                                Console.Write("Date of birth:");
                                Console.WriteLine(Students[i].GetDate());
                                Console.Write("Sex:");
                                if (Students[i].GetSexPerson() == 0)
                                {
                                    Console.WriteLine("Male");
                                }
                                else
                                {
                                    Console.WriteLine("Female");
                                }
                                Console.Write("Id:");
                                Console.WriteLine(Students[i].GetIdStudents());
                                Console.Write("Number:");
                                Console.WriteLine(Students[i].GetNumbre());
                                Console.Write("Course:");
                                Console.WriteLine(Students[i].GetCourse());
                                Console.Write("Avarage score:");
                                Console.WriteLine(Students[i].GetAverageScore());
                                Console.WriteLine();
                            }
                            Console.WriteLine("Press any key to go back!");
                            Console.ReadLine();
                            break;
                        case 6:
                            programOn = false;
                            break;
                        default:
                            continue;
                    }
                }
                catch(Exception exeption)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: " + exeption.Message);
                    Console.WriteLine("Для продолжения нажмите любую клавишу!");
                    Console.ReadLine();
                }
                }
        }
    }
}
/*
menu:

int numberOfChoise = 0;
Console.WriteLine("Select an action number:");
Console.WriteLine("1.Create person");
Console.WriteLine("2.Delete person");
Console.WriteLine("3.Show information about person");
Console.WriteLine("4.Change information");
Console.WriteLine("5.Show info about all Students");
Console.WriteLine("6.Exit");
Console.Write("Type the number:");
string numberOfChoiseStr;
numberOfChoise = 
numberOfChoise = int.Parse(Console.ReadLine());
switch (numberOfChoise)
{
    case 1:
        Console.Clear();
        Create:
        int numberCreate = 0;
        Console.WriteLine("Select an action number:");
        Console.WriteLine("1.Create Teacher");
        Console.WriteLine("2.Create Student");
        Console.WriteLine("3.Back");
        Console.Write("Type the number:");
        numberCreate = int.Parse(Console.ReadLine());
        switch (numberCreate)
        {
            case 1:
                nowTeachers++;
                teachersMass[nowTeachers-1] = CreateTeacher();
                break;
            case 2:
                nowStudents++;
                studentsMass[nowStudents-1] = CreateStudent();
                break;
            case 3:
                Console.Clear();
                goto menu;
            default:
                Console.Clear();
                Console.WriteLine("Wrong number!!!");
                goto Create;
        }

        Console.WriteLine("Press any key to go back!");
        string op1 = Console.ReadLine();
        Console.Clear();
        goto menu;
    case 2:
        Console.Clear();
        Delete:
        Console.WriteLine("Select an action number:");
        Console.WriteLine("1.Delete Teacher");
        Console.WriteLine("2.Delete Student");
        Console.WriteLine("3.Back");
        Console.Write("Type the number:");
        numberCreate = int.Parse(Console.ReadLine());
        switch (numberCreate)
        {
            case 1:
            DeleteTeacher:
               int flag1 = 0;
                Console.Write("Enter id:");
                int idTeacher;
                idTeacher = int.Parse(Console.ReadLine());
                for (int i = 0; i < nowTeachers; i++)
                {
                    if(teachersMass[i].GetIdTeacher() == idTeacher)
                    {
                        flag1 = 1;
                        for(int j = i; j < nowTeachers - 1; j++)
                        {
                            teachersMass[j] = teachersMass[j + 1];
                        }
                        nowTeachers--;
                    }

                }
                if (flag1 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong id!!!");
                    goto DeleteTeacher;
                }
                break;
            case 2:
            DeleteStudent:
                int flag2 = 0;
                Console.Write("Enter id:");
                int idStudent;
                idStudent = int.Parse(Console.ReadLine());
                for (int i = 0; i < nowStudents; i++)
                {
                    if (studentsMass[i].GetIdStudents() == idStudent)
                    {
                        flag2 = 1;
                        for (int j = i; j < nowStudents - 1; j++)
                        {
                            studentsMass[j] = studentsMass[j + 1];
                        }
                        nowStudents--;

                    }

                }
                if (flag2 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong id!!!");
                    goto DeleteStudent;
                }
                break;
            case 3:
                Console.Clear();
                goto menu;
            default:
                Console.Clear();
                Console.WriteLine("Wrong number!!!");
                goto Delete;
        }
        Console.WriteLine("Press any key to go back!");
        string op2 = Console.ReadLine();
        Console.Clear();
        goto menu;
    case 3:
        Console.Clear();
        Info:
        Console.WriteLine("Select an action number:");
        Console.WriteLine("1.Info about Teacher");
        Console.WriteLine("2.Info about Student");
        Console.WriteLine("3.Back");
        Console.Write("Type the number:");
        numberCreate = int.Parse(Console.ReadLine());
        switch (numberCreate)
        {
            case 1:
            InfoTeacher:
                int flag1 = 0;
                Console.Write("Enter id:");
                int idTeacher;
                idTeacher = int.Parse(Console.ReadLine());
                for (int i = 0; i < nowTeachers; i++)
                {
                    if (teachersMass[i].GetIdTeacher() == idTeacher)
                    {
                        flag1 = 1;
                        Console.Write("Name:");
                        Console.WriteLine(teachersMass[i].GetName());
                        Console.Write("Surname:");
                        Console.WriteLine(teachersMass[i].GetSurname());
                        Console.Write("Date of birth:");
                        Console.WriteLine(teachersMass[i].GetDate());
                        Console.Write("Sex:");
                        if(teachersMass[i].GetSexPerson() == 0)
                        {
                            Console.WriteLine("Male");
                        }
                        else
                        {
                            Console.WriteLine("Female");
                        }
                        Console.Write("Id:");
                        Console.WriteLine(teachersMass[i].GetIdTeacher());
                        Console.Write("Experience:");
                        Console.WriteLine(teachersMass[i].GetExperience());
                        Console.Write("Subjects:");
                        foreach (var name in teachersMass[i].GetSubjects())
                            Console.Write(name + " ");
                        Console.WriteLine();
                    }

                }
                if (flag1 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong id!!!");
                    goto InfoTeacher;
                }
                break;
            case 2:
            InfoStudent:
                int flag2 = 0;
                Console.Write("Enter id:");
                int idStudent;
                idStudent = int.Parse(Console.ReadLine());
                for (int i = 0; i < nowStudents; i++)
                {
                    if (studentsMass[i].GetIdStudents() == idStudent)
                    {
                        flag2 = 1;
                        Console.Write("Name:");
                        Console.WriteLine(studentsMass[i].GetName());
                        Console.Write("Surname:");
                        Console.WriteLine(studentsMass[i].GetSurname());
                        Console.Write("Date of birth:");
                        Console.WriteLine(studentsMass[i].GetDate());
                        Console.Write("Sex:");
                        if (studentsMass[i].GetSexPerson() == 0)
                        {
                            Console.WriteLine("Male");
                        }
                        else
                        {
                            Console.WriteLine("Female");
                        }
                        Console.Write("Id:");
                        Console.WriteLine(studentsMass[i].GetIdStudents());
                        Console.Write("Number:");
                        Console.WriteLine(studentsMass[i].GetNumbre());
                        Console.Write("Course:");
                        Console.WriteLine(studentsMass[i].GetCourse());
                        Console.Write("Avarage score:");
                        Console.WriteLine(studentsMass[i].GetAverageScore());
                    }

                }
                if (flag2 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong id!!!");
                    goto InfoStudent;
                }
                break;
            case 3:
                Console.Clear();
                goto menu;
            default:
                Console.Clear();
                Console.WriteLine("Wrong number!!!");
                goto Info;
        }
        Console.WriteLine("Press any key to go back!");
        string op3 = Console.ReadLine();
        Console.Clear();
        goto menu;

    case 4:
        Console.Clear();
        Change:
        Console.WriteLine("Select an action number:");
        Console.WriteLine("1.Change Teachers info");
        Console.WriteLine("2.Change Students info");
        Console.WriteLine("3.Back");
        Console.Write("Type the number:");
        numberCreate = int.Parse(Console.ReadLine());
        switch (numberCreate)
        {
            case 1:
                Console.Write("Enter id:");
                int idTeacher;
                idTeacher = int.Parse(Console.ReadLine());
                for (int i = 0; i < nowTeachers; i++)
                {
                    if (teachersMass[i].GetIdTeacher() == idTeacher)
                    {
                        Console.Clear();
                       Change1:

                        Console.Write("Name:");
                        Console.WriteLine(teachersMass[i].GetName());
                        Console.Write("Surname:");
                        Console.WriteLine(teachersMass[i].GetSurname());
                        Console.Write("Date of birth:");
                        Console.WriteLine(teachersMass[i].GetDate());
                        Console.Write("Sex:");
                        if (teachersMass[i].GetSexPerson() == 0)
                        {
                            Console.WriteLine("Male");
                        }
                        else
                        {
                            Console.WriteLine("Female");
                        }
                        Console.Write("Id:");
                        Console.WriteLine(teachersMass[i].GetIdTeacher());
                        Console.Write("Experience:");
                        Console.WriteLine(teachersMass[i].GetExperience());
                        Console.Write("Subjects:");
                        foreach (var sub in teachersMass[i].GetSubjects())
                            Console.Write(sub + " ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Select the number that you want to change:");
                        Console.WriteLine("1.Name");
                        Console.WriteLine("2.Surname");
                        Console.WriteLine("3.Date of birth");
                        Console.WriteLine("4.Sex");
                        Console.WriteLine("5.Id");
                        Console.WriteLine("6.Experience");
                        Console.WriteLine("7.Subjects");
                        Console.WriteLine("8.Back");
                        int choise;
                        string name, surname, date;
                        int sex, id, exp, numb;
                        List<string> subj = new List<string>();
                        Console.Write("Type the number:");
                        choise = int.Parse(Console.ReadLine());
                        switch (choise)
                        {
                            case 1:
                            f1:
                                Console.Write("Enter name:");
                                name = Console.ReadLine();
                                if (name.Length == 0 || name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9") || name.Contains("0") || name.Contains("!") || name.Contains("@") || name.Contains("#") || name.Contains("$") || name.Contains("%") || name.Contains("^") || name.Contains("&") || name.Contains("*") || name.Contains("(") || name.Contains(")") || name.Contains("_") || name.Contains("=") || name.Contains("+") || name.Contains("-") || name.Contains("/"))
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f1;
                                }
                                teachersMass[i].SetName(name);
                                Console.Clear();
                                goto Change1;
                            case 2:
                            f2:
                                Console.Write("Enter surname:");
                                surname = Console.ReadLine();
                                if (surname.Length == 0 || surname.Length == 0 || surname.Contains("1") || surname.Contains("2") || surname.Contains("3") || surname.Contains("4") || surname.Contains("5") || surname.Contains("6") || surname.Contains("7") || surname.Contains("8") || surname.Contains("9") || surname.Contains("0") || surname.Contains("!") || surname.Contains("@") || surname.Contains("#") || surname.Contains("$") || surname.Contains("%") || surname.Contains("^") || surname.Contains("&") || surname.Contains("*") || surname.Contains("(") || surname.Contains(")") || surname.Contains("_") || surname.Contains("=") || surname.Contains("+") || surname.Contains("-") || surname.Contains("/"))
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f2;
                                }
                                teachersMass[i].SetSurname(surname);
                                Console.Clear();
                                goto Change1;
                            case 3:
                            f3:
                                Console.Write("Enter date of birth:");
                                date = Console.ReadLine();
                                if (date.Length == 0 || date.Length == 0 || date.Contains("!") || date.Contains("@") || date.Contains("#") || date.Contains("$") || date.Contains("%") || date.Contains("^") || date.Contains("&") || date.Contains("*") || date.Contains("(") || date.Contains(")") || date.Contains("_") || date.Contains("=") || date.Contains("+") || date.Contains("-") || date.Contains("/"))
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f3;
                                }
                                teachersMass[i].SetDate(date);
                                Console.Clear();
                                goto Change1;
                            case 4:
                            f4:
                                Console.Write("Enter sex(0 - if male, 1 - if female):");
                                sex = int.Parse(Console.ReadLine());
                                if (sex < 0 || sex > 1)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f4;
                                }
                                teachersMass[i].SetSexPerson(sex);
                                Console.Clear();
                                goto Change1;
                            case 5:
                            f5:
                                Console.Write("Enter id:");
                                id = int.Parse(Console.ReadLine());
                                if (id < 0)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f5;
                                }
                                teachersMass[i].SetIdTeacher(id);
                                Console.Clear();
                                goto Change1;
                            case 6:
                            f6:
                                Console.Write("Enter expirience:");
                                exp = int.Parse(Console.ReadLine());
                                if (exp < 0)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f6;
                                }
                                teachersMass[i].SetExperience(exp);
                                Console.Clear();
                                goto Change1;
                            case 7:
                            f7:
                                Console.Write("Enter number of subjects:");
                                numb = int.Parse(Console.ReadLine());
                                if (numb < 0)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f7;
                                }
                                for (int j = 0; j < numb; j++)
                                {
                                f8:
                                    string subj1;
                                    Console.Write("Enter subject # {0}:", j + 1);
                                    subj1 = Console.ReadLine();
                                    if ( subj1.Length == 0 || subj1.Contains("1") || subj1.Contains("2") || subj1.Contains("3") || subj1.Contains("4") || subj1.Contains("5") || subj1.Contains("6") || subj1.Contains("7") || subj1.Contains("8") || subj1.Contains("9") || subj1.Contains("0") || subj1.Contains("!") || subj1.Contains("@") || subj1.Contains("#") || subj1.Contains("$") || subj1.Contains("%") || subj1.Contains("^") || subj1.Contains("&") || subj1.Contains("*") || subj1.Contains("(") || subj1.Contains(")") || subj1.Contains("_") || subj1.Contains("=") || subj1.Contains("+") || subj1.Contains("-") || subj1.Contains("/"))
                                    {
                                        Console.WriteLine("Incorrect info!");
                                        goto f8;
                                    }
                                    subj.Add(subj1);
                                }
                                teachersMass[i].SetSubjects(subj);
                                Console.Clear();
                                goto Change1;
                            case 8:
                                Console.Clear();
                                goto Change;
                            default:
                                Console.Clear();
                                Console.WriteLine("Wrong number!!!");
                                goto Change1;
                        }
                    }

                }

                break;

            case 2:

                Console.Write("Enter id:");
                int idStudent;
                idStudent = int.Parse(Console.ReadLine());
                for (int i = 0; i < nowStudents; i++)
                {
                    if (studentsMass[i].GetIdStudents() == idStudent)
                    {
                        Console.Clear();
                    ChangeS1:

                        Console.Write("Name:");
                        Console.WriteLine(studentsMass[i].GetName());
                        Console.Write("Surname:");
                        Console.WriteLine(studentsMass[i].GetSurname());
                        Console.Write("Date of birth:");
                        Console.WriteLine(studentsMass[i].GetDate());
                        Console.Write("Sex:");
                        if (studentsMass[i].GetSexPerson() == 0)
                        {
                            Console.WriteLine("Male");
                        }
                        else
                        {
                            Console.WriteLine("Female");
                        }
                        Console.Write("Id:");
                        Console.WriteLine(studentsMass[i].GetIdStudents());
                        Console.Write("Number:");
                        Console.WriteLine(studentsMass[i].GetNumbre());
                        Console.Write("Course:");
                        Console.WriteLine(studentsMass[i].GetCourse());
                        Console.Write("Avarage score:");
                        Console.WriteLine(studentsMass[i].GetAverageScore());
                        Console.WriteLine();
                        Console.WriteLine("Select the number that you want to change:");
                        Console.WriteLine("1.Name");
                        Console.WriteLine("2.Surname");
                        Console.WriteLine("3.Date of birth");
                        Console.WriteLine("4.Sex");
                        Console.WriteLine("5.Id");
                        Console.WriteLine("6.Number");
                        Console.WriteLine("7.Course");
                        Console.WriteLine("8.Avarage score");
                        Console.WriteLine("9.Back");
                        int choise;
                        string name, surname, date;
                        int sex, id, number, course;
                        double avaregscore;
                        Console.Write("Type the number:");
                        choise = int.Parse(Console.ReadLine());
                        switch (choise)
                        {
                            case 1:
                            f1:
                                Console.Write("Enter name:");
                                name = Console.ReadLine();
                                if (name.Length == 0 || name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9") || name.Contains("0") || name.Contains("!") || name.Contains("@") || name.Contains("#") || name.Contains("$") || name.Contains("%") || name.Contains("^") || name.Contains("&") || name.Contains("*") || name.Contains("(") || name.Contains(")") || name.Contains("_") || name.Contains("=") || name.Contains("+") || name.Contains("-") || name.Contains("/"))
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f1;
                                }
                                studentsMass[i].SetName(name);
                                Console.Clear();
                                goto ChangeS1;
                            case 2:
                            f2:
                                Console.Write("Enter surname:");
                                surname = Console.ReadLine();
                                if (surname.Length == 0 || surname.Length == 0 || surname.Contains("1") || surname.Contains("2") || surname.Contains("3") || surname.Contains("4") || surname.Contains("5") || surname.Contains("6") || surname.Contains("7") || surname.Contains("8") || surname.Contains("9") || surname.Contains("0") || surname.Contains("!") || surname.Contains("@") || surname.Contains("#") || surname.Contains("$") || surname.Contains("%") || surname.Contains("^") || surname.Contains("&") || surname.Contains("*") || surname.Contains("(") || surname.Contains(")") || surname.Contains("_") || surname.Contains("=") || surname.Contains("+") || surname.Contains("-") || surname.Contains("/"))
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f2;
                                }
                                studentsMass[i].SetSurname(surname);
                                Console.Clear();
                                goto ChangeS1;
                            case 3:
                            f3:
                                Console.Write("Enter date of birth:");
                                date = Console.ReadLine();
                                if (date.Length == 0 || date.Length == 0 || date.Contains("!") || date.Contains("@") || date.Contains("#") || date.Contains("$") || date.Contains("%") || date.Contains("^") || date.Contains("&") || date.Contains("*") || date.Contains("(") || date.Contains(")") || date.Contains("_") || date.Contains("=") || date.Contains("+") || date.Contains("-") || date.Contains("/"))
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f3;
                                }
                                studentsMass[i].SetDate(date);
                                Console.Clear();
                                goto ChangeS1;
                            case 4:
                            f4:
                                Console.Write("Enter sex(0 - if male, 1 - if female):");
                                sex = int.Parse(Console.ReadLine());
                                if (sex < 0 || sex > 1)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f4;
                                }
                                studentsMass[i].SetSexPerson(sex);
                                Console.Clear();
                                goto ChangeS1;
                            case 5:
                            f5:
                                Console.Write("Enter id:");
                                id = int.Parse(Console.ReadLine());
                                if (id < 0)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f5;
                                }
                                studentsMass[i].SetIdStudents(id);
                                Console.Clear();
                                goto ChangeS1;
                            case 6:
                            f6:
                                Console.Write("Enter number:");
                                number = int.Parse(Console.ReadLine());
                                if (number < 0)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f6;
                                }
                                studentsMass[i].SetNumbre(number);
                                Console.Clear();
                                goto ChangeS1;
                            case 7:
                            f7:
                                Console.Write("Enter course:");
                                course = int.Parse(Console.ReadLine());
                                if (course < 0 || course > 5)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f7;
                                }
                                studentsMass[i].SetCourse(course);
                                Console.Clear();
                                goto ChangeS1;
                            case 8:
                            f8:
                                Console.Write("Enter avarage score:");
                                avaregscore = int.Parse(Console.ReadLine());
                                if (avaregscore < 0 || avaregscore > 5)
                                {
                                    Console.WriteLine("Incorrect info!");
                                    goto f8;
                                }
                                studentsMass[i].SetAverageScore(avaregscore);
                                Console.Clear();
                                goto ChangeS1;
                            case 9:
                                Console.Clear();
                                goto Change;
                            default:
                                Console.Clear();
                                Console.WriteLine("Wrong number!!!");
                                goto ChangeS1;
                        }
                    }

                }

                break;
            case 3:
                Console.Clear();
                goto menu;
            default:
                Console.Clear();
                Console.WriteLine("Wrong number!!!");
                goto Change;
        }
        Console.WriteLine("Press any key to go back!");
        string op4 = Console.ReadLine();
        Console.Clear();
        goto menu;
    case 5:
        Console.Clear();
        Student cont = new Student();
        Console.WriteLine("Information about all Students:");
        for (int j = 0; j < nowStudents; j++)
        {
            for (int i = 0; i < nowStudents - 1; i++)
            {
                string str1, str2;
                str1 = studentsMass[i].GetName();
                str2 = studentsMass[i + 1].GetName();
                if (str1.CompareTo(str2) > 0)
                {
                    cont = studentsMass[i];
                    studentsMass[i] = studentsMass[i + 1];
                    studentsMass[i + 1] = cont;
                }
            }
        }
        for (int i = 0; i < nowStudents - 1; i++)
        {
            Console.Write("Name:");
            Console.WriteLine(studentsMass[i].GetName());
            Console.Write("Surname:");
            Console.WriteLine(studentsMass[i].GetSurname());
            Console.Write("Date of birth:");
            Console.WriteLine(studentsMass[i].GetDate());
            Console.Write("Sex:");
            if (studentsMass[i].GetSexPerson() == 0)
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("Female");
            }
            Console.Write("Id:");
            Console.WriteLine(studentsMass[i].GetIdStudents());
            Console.Write("Number:");
            Console.WriteLine(studentsMass[i].GetNumbre());
            Console.Write("Course:");
            Console.WriteLine(studentsMass[i].GetCourse());
            Console.Write("Avarage score:");
            Console.WriteLine(studentsMass[i].GetAverageScore());
            Console.WriteLine();
        }
        Console.WriteLine("Press any key to go back!");
        string op5 = Console.ReadLine();
        Console.Clear();
        goto menu;
    case 6:
        Environment.Exit(0);
        break;
    default:
        Console.Clear();
        Console.WriteLine("Wrong number!!!");
        goto menu;
}
Console.Read();
}
}
}*/
