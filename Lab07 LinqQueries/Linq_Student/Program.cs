using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Student
{
    class Program
    {
        public class Student
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int studentID { get; set; }
            public List<int> scores;
        }

        static List<Student> students = new List<Student>
        {
            new Student{firstName = "Svetlana", lastName="Omelchenko", studentID = 111,
                scores = new List<int>{ 97, 92, 81, 60}},
            new Student {firstName = "Claire", lastName = "O'Donnell", studentID = 112,
                scores = new List<int>{75, 84, 91, 30}},
            new Student {firstName = "Sebastian", lastName = "Ocean", studentID = 113,
                scores = new List<int>{95, 80, 61, 50}},
            new Student {firstName = "Migel", lastName = "Rodrigez", studentID = 114,
                scores = new List<int>{92, 54, 76, 75}},
            new Student {firstName = "Patricia", lastName = "Smith", studentID = 115,
                scores = new List<int>{98, 90, 91, 79}},
            new Student {firstName = "John", lastName = "Smith", studentID = 116,
                scores = new List<int>{89, 80, 74, 63}},
            new Student {firstName = "Rachel", lastName = "Robertson", studentID = 117,
                scores = new List<int>{86, 92, 84, 88}},
            new Student {firstName = "Timothy", lastName = "Johnson", studentID = 118,
                scores = new List<int>{85, 94, 89, 87}},
        };
        static void Main(string[] args)
        {
            Console.WriteLine("First Query:");
            IEnumerable<Student> studentQuery =
                from student in students
                where student.scores[0] > 90 && student.scores[3] < 80
                orderby student.scores[0] descending
                select student;
            foreach(Student student in studentQuery)
            {
                Console.WriteLine($"{student.lastName}, {student.firstName} {student.scores[0]}");
            }

            Console.WriteLine("\nSecond Query:");
            var studentQuery2 =
                from student in students
                group student by student.lastName[0];
            foreach(var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine($"{student.lastName}, {student.firstName}");
                }
            }

            Console.WriteLine("\nThird Query:");
            var studentQuery3 =
                from student in students
                group student by student.lastName[0];
            foreach(var groupOfStudents in studentQuery3)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach(var student in groupOfStudents)
                {
                    Console.WriteLine($"{student.lastName}, {student.firstName}");
                }
            }

            Console.WriteLine("\nFourth Query:");
            var studentQuery4 =
                from student in students
                group student by student.lastName[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;
            foreach(var groupOfStudents in studentQuery4)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach(var student in groupOfStudents)
                {
                    Console.WriteLine($"{student.lastName}, {student.firstName}");
                }

            }

            Console.WriteLine("\nFifth Query:");
            var studentQuery5 =
                from student in students
                let totalScore = student.scores[0] + student.scores[1] + student.scores[2] + student.scores[3]
                where totalScore / 4 < student.scores[0]
                orderby student.lastName, student.firstName
                select student.lastName + " " + student.firstName;
            foreach(string s in studentQuery5)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("\nSixth Query:");
            var studentQuery6 =
                from student in students
                let totalScore = student.scores[0] + student.scores[1] + student.scores[2] + student.scores[3]
                select totalScore;

            double averageScore = studentQuery6.Average();
            Console.WriteLine($"Class average score = {averageScore}");
            
            Console.WriteLine("\nSeventh Query:");
            IEnumerable<string> studentQuery7 =
                from student in students
                where student.lastName == "Smith"
                select student.firstName;
            Console.WriteLine("The Smiths in the class are:");
            foreach(string name in studentQuery7)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nEigth Query:");
            var studentQuery8 =
                from student in students
                let totalStudScore = student.scores[0] + student.scores[1] + student.scores[2] + student.scores[3]
                where totalStudScore > averageScore
                select new { id = student.studentID, score = totalStudScore };
            foreach (var item in studentQuery8)
            {
                Console.WriteLine($"StudentID = {item.id}, Score = {item.score}");
            }
        }
    }
}
