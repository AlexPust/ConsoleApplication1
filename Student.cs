using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student: Person
    {
        private int idStudents;
        private int number;
        private int course;
        private double averageScore;
        public Student(): base()
        {
            idStudents = 0;
            number = 0;
            course = 0;
            averageScore = 0;
        }
        public Student(string _name, string _surname, string _date, int _sex, int _id, int _number,int _course, double _score) : base(_name, _surname, _date, _sex)
        {
            idStudents = _id;
            number = _number;
            course = _course;
            averageScore = _score;
        }
        public void SetIdStudents(int _id)
        {
            idStudents = _id;
        }
        public void SetNumbre(int _number)
        {
            number = _number;
        }
        public void SetCourse(int _course)
        {
            course = _course;
        }
        public void SetAverageScore(double _score)
        {
            averageScore = _score;
        }
        public int GetIdStudents()
        {
            return idStudents;
        }
        public int GetNumbre()
        {
            return number;
        }
        public int GetCourse()
        {
            return course;
        }
        public double GetAverageScore()
        {
            return averageScore;
        }
    }
}
