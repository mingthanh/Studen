using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tao danh sach
            List<Student> students = new List<Student>();

            // nhap
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"nhap thong tin hoc sinh thu {i + 1}:");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Ten: ");
                string name = Console.ReadLine();

                Console.Write("Tuoi: ");
                int age = int.Parse(Console.ReadLine());

                students.Add(new Student { ID = id, Name = name, Age = age });
            }

            // xuat
            Console.WriteLine("\ndanh sach hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
            }

            // B. tim va in ra danh sach cac hoc sinh co tuoi tu 15 den 18
            var studentsInAgeRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
            Console.WriteLine("\nHS có tuoi tu 15 den 18:");
            foreach (var student in studentsInAgeRange)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
            }

            // C. tim va in ra hs co ten bat dau bang chu "A"
            var studentsWithNameStartingWithA = students.Where(s => s.Name.StartsWith("A"));
            Console.WriteLine("\nHS co ten bat dau bang chu 'A':");
            foreach (var student in studentsWithNameStartingWithA)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
            }

            // D. tinh tong tuoi cua tat ca hs trong ds
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\ntong tuoi cua tat ca cac hs: {totalAge}");

            // E. tim va in ra hs co tuoi lon nhat
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine($"\nHS co tuoi lon nhat: ID: {oldestStudent.ID}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

            // F. sx ds hs theo tuoi tang dan va in ra ds khi sx
            var sortedStudents = students.OrderBy(s => s.Age);
            Console.WriteLine("\nds da sap xep:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
