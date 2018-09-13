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
            List<Student> Group = new List<Student>();
            Group.Add(Student1); Group.Add(Student2); Group.Add(Student3); Group.Add(Student4); Group.Add(Student5); Group.Add(Student6);
            double averageGroupScore = 0;
            foreach (Student i in Group)
            {
                i.ShowInfo();
                averageGroupScore = averageGroupScore + i.AverageScore();
            }
            Console.WriteLine("Average group score: " + (averageGroupScore/Group.Count) + "\n");

            List<Student> Group2 = Group;
            Console.WriteLine("\nNew Group is created.\nEnter 1 to add new student to the group or enter 0 to get group statistic.\n");
            int a = int.Parse(Console.ReadLine());

            while(a!=0)
            {
                Console.WriteLine("\nEnter the data about new student\n");
                Console.WriteLine("Name: "); string _name = Console.ReadLine();
                Console.WriteLine("First mark: "); int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Second mark: "); int m2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Third mark: "); int m3 = int.Parse(Console.ReadLine());
                Group2.Add(new Student(m1, m2, m3, _name));
                Console.WriteLine("\nEnter 1 to add new student to the group or enter 0 to get group statistic.");
                a = int.Parse(Console.ReadLine());
            }

            double averageGroup2Score = 0;
            foreach (Student i in Group2)
            {
                i.ShowInfo();
                averageGroup2Score = averageGroup2Score + i.AverageScore();
            }
            Console.WriteLine("Average score of the second group: " + (averageGroup2Score / Group2.Count) + "\n");

        }
    }
}
