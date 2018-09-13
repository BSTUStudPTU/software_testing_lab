using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student(5, 5, 5, "Egor");
            Student Student2 = new Student(4, 4, 4, "Anton");
            Student Student3 = new Student(6, 6, 6, "Artem");
            Student Student4 = new Student(7, 7, 7, "Sasha");
            Student Student5 = new Student(8, 8, 8, "Pasha");
            Student Student6 = new Student(9, 9, 9, "Dasha");
            List<Object> Group = new List<object>();
            Group.Add(Student1); Group.Add(Student2); Group.Add(Student3); Group.Add(Student4); Group.Add(Student5); Group.Add(Student6);
            double averageGroupScore = 0;
            foreach (Student i in Group)
            {
                i.ShowInfo();
                averageGroupScore = averageGroupScore + i.AverageScore();
            }
            Console.WriteLine("Average group score: " + (averageGroupScore/Group.Count) + "\n");

            List<Student> Group2 = new List<Student>();
            Console.WriteLine("\nNew Group is created. \nEnter 1 to add new student to the group or enter 0 to get info\n");
        }
    }
}
