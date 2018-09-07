using System;
using static ConsoleApplication1.FunctionalPeople;
using static ConsoleApplication1.FunctionalUniversitet;


namespace ConsoleApplication1
{
    class Menu
    {
        FunctionalPeople functionalPeople = new FunctionalPeople();
        FunctionalUniversitet functionalUniversitet = new FunctionalUniversitet();
        public void CreateMenu()
        {
            bool programOn = true;
            while (programOn)
            {
                try
                {
                    Console.Clear();
                    byte numberOfChoise = 0;
                    Console.WriteLine("Select an action number:");
                    Console.WriteLine("1.Create Teacher");
                    Console.WriteLine("2.Create Student");
                    Console.WriteLine("3.Create Group");
                    Console.WriteLine("4.Create Subject");
                    Console.WriteLine("5.Create Curriculum");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("0.Back");
                    Console.Write("Type the number:");
                    if (!byte.TryParse(Console.ReadLine(), out numberOfChoise)) throw new Exception("Wrong info!");
                    if (numberOfChoise < 0 || numberOfChoise > 5) throw new Exception("Wrong number!");
                    Console.Clear();
                    switch (numberOfChoise)
                    {
                        case 1:
                            Teatcher teacher = new Teatcher();
                            teacher.TeacherChangeInfo();
                            functionalPeople.Add<Teatcher>(teacher, Teachers);
                            break;
                        case 2:
                            Student student = new Student();
                            student.StudentChangeInfo();
                            functionalPeople.Add<Student>(student, Students);
                            break;
                        case 3:
                            Group group = new Group();
                            group.GroupChangeInfo();
                            functionalUniversitet.Add(group, Groups);
                            break;
                        case 4:
                            Subject subject = new Subject();
                            subject.SubjectChangeInfo();
                            functionalUniversitet.Add(subject, Subjects);
                            break;
                        case 5:
                            Curriculum curriculum = new Curriculum();
                            curriculum.CurriculumChangeInfo();
                            functionalUniversitet.Add(curriculum, Curriculums);
                            break;
                        case 0:
                            programOn = false;
                            break;
                        default:
                            continue;
                    }
                }
                catch (Exception exeption)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: " + exeption.Message);
                    Console.WriteLine("Для продолжения нажмите любую клавишу!");
                    Console.ReadKey();
                }
            }
        }
        public void DeleteMenu()
        {
            bool programOn = true;
            while (programOn)
            {
                try
                {
                    Console.Clear();

                    byte numberOfChoise = 0;
                    Console.WriteLine("Select an action number:");
                    Console.WriteLine("1.Delete Teacher");
                    Console.WriteLine("2.Delete Student");
                    Console.WriteLine("3.Delete Group");
                    Console.WriteLine("4.Delete Subject");
                    Console.WriteLine("5.Delete Curriculum");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("0.Back");
                    Console.Write("Type the number:");
                    if (!byte.TryParse(Console.ReadLine(), out numberOfChoise)) throw new Exception("Wrong info!");
                    if (numberOfChoise < 0 || numberOfChoise > 5) throw new Exception("Wrong number!");
                    Console.Clear();
                    switch (numberOfChoise)
                    {
                        case 1:
                            functionalPeople.Delete(Teachers);
                            break;
                        case 2:
                            functionalPeople.Delete(Students);
                            break;
                        case 3:
                            functionalUniversitet.Delete(Groups);
                            break;
                        case 4:
                            functionalUniversitet.Delete(Subjects);
                            break;
                        case 5:
                            functionalUniversitet.Delete(Curriculums);
                            break;
                        case 0:
                            programOn = false;
                            break;
                        default:
                            continue;
                    }
                }
                catch (Exception exeption)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: " + exeption.Message);
                    Console.WriteLine("Для продолжения нажмите любую клавишу!");
                    Console.ReadKey();
                }
            }
        }
        public void ShowInfoMenu()
        {
            bool programOn = true;
            while (programOn)
            {
                try
                {
                    Console.Clear();
                    byte numberOfChoise = 0;
                    Console.WriteLine("Select an action number:");
                    Console.WriteLine("1.Show information about Teacher");
                    Console.WriteLine("2.Show information about Student");
                    Console.WriteLine("3.Show information about Group");
                    Console.WriteLine("4.Show information about Subject");
                    Console.WriteLine("5.Show information about Curriculum");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("0.Back");
                    Console.Write("Type the number:");
                    if (!byte.TryParse(Console.ReadLine(), out numberOfChoise)) throw new Exception("Wrong info!");
                    if (numberOfChoise < 0 || numberOfChoise > 5) throw new Exception("Wrong number!");
                    Console.Clear();
                    switch (numberOfChoise)
                    {
                        case 1:
                            functionalPeople.ShowInfo(Teachers);
                            break;
                        case 2:
                            functionalPeople.ShowInfo(Students);
                            break;
                        case 3:
                            functionalUniversitet.ShowInfo(Groups);
                            break;
                        case 4:
                            functionalUniversitet.ShowInfo(Subjects);
                            break;
                        case 5:
                            functionalUniversitet.ShowInfo(Curriculums);
                            break;
                        case 0:
                            programOn = false;
                            break;
                        default:
                            continue;
                    }
                }
                catch (Exception exeption)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: " + exeption.Message);
                    Console.WriteLine("Для продолжения нажмите любую клавишу!");
                    Console.ReadKey();
                }
            }
        }
        public void ChangeInfoMenu()
        {
            bool programOn = true;
            while (programOn)
            {
                try
                {
                    Console.Clear();
                    byte numberOfChoise = 0;
                    Console.WriteLine("Select an action number:");
                    Console.WriteLine("1.Change Teacher's information");
                    Console.WriteLine("2.Change Student's information");
                    Console.WriteLine("3.Change Group's information");
                    Console.WriteLine("4.Change Subject's information");
                    Console.WriteLine("5.Change Curriculum's information");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("0.Back");
                    Console.Write("Type the number:");
                    if (!byte.TryParse(Console.ReadLine(), out numberOfChoise)) throw new Exception("Wrong info!");
                    if (numberOfChoise < 0 || numberOfChoise > 5) throw new Exception("Wrong number!");
                    Console.Clear();
                    switch (numberOfChoise)
                    {
                        case 1:
                            functionalPeople.Edit(new Teatcher());
                            break;
                        case 2:
                            functionalPeople.Edit(new Student());
                            break;
                        case 3:
                            functionalUniversitet.Edit(new Group());
                            break;
                        case 4:
                            functionalUniversitet.Edit(new Subject());
                            break;
                        case 5:
                            functionalUniversitet.Edit(new Curriculum());
                            break;
                        case 0:
                            programOn = false;
                            break;
                        default:
                            continue;
                    }
                }
                catch (Exception exeption)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: " + exeption.Message);
                    Console.WriteLine("Для продолжения нажмите любую клавишу!");
                    Console.ReadKey();
                }
            }
        }
        public void ShowAllInfoMenu()
        {
            bool programOn = true;
            while (programOn)
            {
                try
                {
                    Console.Clear();

                    byte numberOfChoise = 0;
                    Console.WriteLine("Select an action number:");
                    Console.WriteLine("1.Show info about all sorted Students");
                    Console.WriteLine("2.Show info about all Teachers");
                    Console.WriteLine("3.Show info about all Groups");
                    Console.WriteLine("4.Show info about all Subjects");
                    Console.WriteLine("5.Show info about all Curriculums");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("0.Back");
                    Console.Write("Type the number:");
                    if (!byte.TryParse(Console.ReadLine(), out numberOfChoise)) throw new Exception("Wrong info!");
                    if (numberOfChoise < 0 || numberOfChoise > 5) throw new Exception("Wrong number!");
                    Console.Clear();
                    switch (numberOfChoise)
                    {
                        case 1:
                            functionalPeople.ShowSordetStudentsInfo();
                            break;
                        case 2:
                            functionalPeople.ShowAllInfo(Teachers);
                            break;
                        case 3:
                            functionalUniversitet.ShowAllInfo(Groups);
                            break;
                        case 4:
                            functionalUniversitet.ShowAllInfo(Subjects);
                            break;
                        case 5:
                            functionalUniversitet.ShowAllInfo(Curriculums);
                            break;
                        case 0:
                            programOn = false;
                            break;
                        default:
                            continue;
                    }
                }
                catch (Exception exeption)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка: " + exeption.Message);
                    Console.WriteLine("Для продолжения нажмите любую клавишу!");
                    Console.ReadKey();
                }
            }
        }
    }
}
