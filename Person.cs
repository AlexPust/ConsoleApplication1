using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum sex { male = 0, female = 1, none = 2 };
namespace ConsoleApplication1
{
    class Person
    {
        private string name;
        private string surname;
        private string date;
        private sex sexPerson;
        public Person()
        {
            name = null;
            surname = null;
            date = null;
            sexPerson = sex.none;
        }
        public Person(string _name,string _surname, string _date, int _sex) 
        {
            name = _name; 
            surname = _surname;
            date = _date;
            if(_sex == 0)
            {
                sexPerson = sex.male;
            }
            if(_sex == 1)
            {
                sexPerson = sex.female;
            }
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetSurname(string _surname)
        {
            surname = _surname;
        }
        public void SetDate(string _date)
        {
            date = _date;
        }
        public void SetSexPerson(int _sex)
        {
            if (_sex == 0)
            {
                sexPerson = sex.male;
            }
            if (_sex == 1)
            {
                sexPerson = sex.female;
            }
        }
        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetDate()
        {
            return date;
        }
        public int GetSexPerson()
        {
            return (int)sexPerson;
        }
    }
}
