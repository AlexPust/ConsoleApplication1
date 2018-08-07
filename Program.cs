using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ConsoleApplication1.Functional;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateBasePersons();
            bool programOn = true;
            while (programOn)
            {
                try {
                    Console.Clear();

                    byte numberOfChoise = 0;
                    Console.WriteLine("Select an action number:");
                    Console.WriteLine("1.Create Teacher");
                    Console.WriteLine("2.Create Student");
                    Console.WriteLine("3.Delete Teacher");
                    Console.WriteLine("4.Delete Student");
                    Console.WriteLine("5.Show information about Teacher");
                    Console.WriteLine("6.Show information about Student");
                    Console.WriteLine("7.Change Teacher's information");
                    Console.WriteLine("8.Change Student's information");
                    Console.WriteLine("9.Show info about all sorted Students");
                    Console.WriteLine("10.Exit");
                    Console.Write("Type the number:");
                    numberOfChoise = byte.Parse(Console.ReadLine());
                    if (numberOfChoise < 0 || numberOfChoise > 10) throw new Exception("Wrong number!");
                    Console.Clear();
                    switch (numberOfChoise)
                    {
                        case 1:
                            CreateNew(new Teatcher());      
                            break;
                        case 2:
                            CreateNew(new Student());
                            break;
                        case 3:
                            Delete(new Teatcher());
                            break;
                        case 4:
                            Delete(new Student());
                            break;
                        case 5:
                            ShowInfo(new Teatcher());
                            break;
                        case 6:
                            ShowInfo(new Student());
                            break;
                        case 7:
                            ChangeInfo(new Teatcher());
                            break;
                        case 8:
                            ChangeInfo(new Student());
                            break;
                         case 9:
                            ShowSordetStudentsInfo();
                             break;
                        case 10:
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
