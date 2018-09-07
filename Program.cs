using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionalPeople functionalPeople = new FunctionalPeople();
            FunctionalUniversitet functionalUniversitet = new FunctionalUniversitet();
            Menu menu = new Menu();
            functionalPeople.CreateBaseInfo();
            functionalUniversitet.CreateBaseInfo();
            bool programOn = true;
            while (programOn)
            {
                try
                {
                    Console.Clear();
                    byte numberOfChoise = 0;
                    Console.WriteLine("Select an action number:");
                    Console.WriteLine("1.Create");
                    Console.WriteLine("2.Delete");
                    Console.WriteLine("3.Change info");
                    Console.WriteLine("4.Show info");
                    Console.WriteLine("5.Show all info");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("0.Exit");
                    Console.Write("Type the number:");
                    if (!byte.TryParse(Console.ReadLine(), out numberOfChoise)) throw new Exception("Wrong info!");
                    if (numberOfChoise < 0 || numberOfChoise > 5) throw new Exception("Wrong number!");
                    Console.Clear();
                    switch (numberOfChoise)
                    {
                        case 1:
                            menu.CreateMenu();
                            break;
                        case 2:
                            menu.DeleteMenu();
                            break;
                        case 3:
                            menu.ChangeInfoMenu();
                            break;
                        case 4:
                            menu.ShowInfoMenu();
                            break;
                        case 5:
                            menu.ShowAllInfoMenu();
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
