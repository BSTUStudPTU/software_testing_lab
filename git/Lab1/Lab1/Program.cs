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
            List<Student> Group = new List<Student>();
            Adding:
            Console.WriteLine("\nEnter 1 to add new student to the group or enter 0 to get group statistic.\n");
            int a = int.Parse(Console.ReadLine());
            if (a != 0 && a != 1) goto Adding;
            while(a!=0)
            {
                Console.WriteLine("\nEnter the data about new student\n");
                Console.WriteLine("Name: "); string _name = Console.ReadLine();
                Console.WriteLine("First mark: "); int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Second mark: "); int m2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Third mark: "); int m3 = int.Parse(Console.ReadLine());
                Group.Add(new Student(m1, m2, m3, _name));
                Console.WriteLine("\nEnter 1 to add new student to the group or enter 0 to get group statistic.");
                a = int.Parse(Console.ReadLine());
            }
            if (Group.Count > 0)
            {
                double averageGroupScore = 0;
                foreach (Student i in Group)
                {
                    i.ShowInfo();
                    averageGroupScore = averageGroupScore + i.AverageScore();
                }
                Console.WriteLine("Average group score: " + (averageGroupScore / Group.Count) + "\n");
            }
            else
            {
                Console.WriteLine("Group is empty!");
                goto Adding;
            } 
        }
    }
}
