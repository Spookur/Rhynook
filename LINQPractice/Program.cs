using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudents(StudentRepository.SelectAll());

            MethodSyntax1();
            MethodSyntax2();
            MethodSyntax3();
            MethodSyntax4();
            MethodSyntax5();
            QuerySyntax1();
            QuerySyntax2();
            QuerySyntax3();
            AnonymousType(); 
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }

        static void MethodSyntax1()
        {
            var students = StudentRepository.SelectAll();

            decimal average = students.Average(s => s.GPA);

            // SCALAR METHODS
            Console.WriteLine("The average GPA is: {0}", average);
            Console.WriteLine("The max GPA is: {0}", students.Max(student => student.GPA));
            Console.WriteLine("");
            
        }

        static void MethodSyntax2()
        {
            Console.WriteLine("Press enter to see the students who have obtained Honor Roll.");
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            var honorRoll = StudentRepository.SelectAll().Where(s => s.GPA >= 3.5M);
            PrintStudents(honorRoll);
        }

        static void MethodSyntax3()
        {
            
            Console.WriteLine("Press enter to see the students in descending order by GPA.");
            
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            Console.Clear();
            var orderByGPA = StudentRepository.SelectAll().OrderByDescending(s => s.GPA);
            PrintStudents(orderByGPA);
        }

        static void MethodSyntax4()
        {
            Console.WriteLine("Press enter to see the top three students in the class.");
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------");
            var topThreeByGPA = StudentRepository.SelectAll().OrderByDescending(s => s.GPA).Take(3);
            PrintStudents(topThreeByGPA);
        }

        static void MethodSyntax5()
        {
            Console.WriteLine("Press enter to see the students grouped by major.");
            Console.ReadLine();
            Console.WriteLine("");
            var groups = StudentRepository.SelectAll().GroupBy(s => s.Major);
            string lineFormat = "{0, -15} {1, -15} {2, 4}";

            foreach (var group in groups)
            {
                Console.WriteLine("Major: {0}", group.Key);
                Console.WriteLine("-----------------------");

                foreach(var student in group)
                {
                    Console.WriteLine(lineFormat, student.LastName, student.FirstName, student.GPA);
                }

                Console.WriteLine();
            }

            
        }

        private static void QuerySyntax1()
        {
            Console.WriteLine("Press enter to see the honor roll students using query syntax.");
            Console.ReadLine();
            Console.WriteLine("------------------------");
            var honorRoll = from s in StudentRepository.SelectAll()
                            where s.GPA >= 3.5M
                            select s;
            PrintStudents(honorRoll);
        }

        private static void QuerySyntax2()
        {
            Console.WriteLine("Press enter to see the top three students by GPA but in ascending order.");
            Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------");
            var topThreebyGPA = (from s in StudentRepository.SelectAll()
                                 orderby s.GPA descending
                                 select s).Take(3);
            PrintStudents(topThreebyGPA);


        }

        private static void QuerySyntax3()
        {
            Console.WriteLine("Press enter to see the groupings and then the key in alphabetical order.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            var groups = from student in StudentRepository.SelectAll()
                         group student by student.Major into newgroup
                         orderby newgroup.Key
                         select newgroup;
            string lineFormat = "{0, -15} {1, -15} {2, 4}";

            foreach (var group in groups)
            {
                Console.WriteLine("Major: {0}", group.Key);
                Console.WriteLine("-----------------------");

                foreach (var student in group)
                {
                    Console.WriteLine(lineFormat, student.LastName, student.FirstName, student.GPA);
                }

                Console.WriteLine();
            }

        }

        static void AnonymousType()
        {
            Console.WriteLine("Press enter to see the students orgainzed by Last Name first.");
            Console.ReadLine();
            Console.WriteLine("");
            var students = from s in StudentRepository.SelectAll()
                           select new { LastFirst = s.LastName + ", " + s.FirstName, s.Major, s.GPA };

            string lineFormat = "{0, -30} {1, -18} {2, 4}";
            Console.WriteLine(lineFormat, "Name", "Major", "GPA");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine(lineFormat, student.LastFirst, student.Major, student.GPA);
            }
        }



        static void PrintStudents(IEnumerable<Student> students)
        {
            string headingFormat = "{0, -15} {1, -15} {2, -18} {3, 4}";
            string lineFormat = "{0, -15} {1, -15} {2, -18} {3, 4}";

            Console.WriteLine(headingFormat, "Last Name", "First Name", "Major", "GPA");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var student in students) 
            {
                Console.WriteLine(lineFormat, student.LastName, student.FirstName, student.Major, student.GPA);
            }

            Console.WriteLine("");
        }
    }
}
