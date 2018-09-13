using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        public int[] marks = new int[3];
        public string name;

        public Student(int a, int b, int c, string name)
        {
            marks[0] = a; marks[1] = b; marks[2] = c;
            this.name = name;
        }

        public double AverageScore()
        {
            double averageScore = 0;
            for (int i = 0; i < marks.Length; i++) { averageScore = averageScore + marks[i]; }
            return averageScore / marks.Length;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Student: " + name +
                "\nMarks: " + marks[0] + ", " + marks[1] + ", " + marks[2] + 
                "\nAverage score: " + AverageScore() + "\n");
        }
    }
}
