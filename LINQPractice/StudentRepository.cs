using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class StudentRepository
    {
        public static List<Student> SelectAll()
        {
            return new List<Student>
            {
                new Student {FirstName = "Joe", LastName = "Smith", Major = "Computer Science", GPA = 3.5M},
                new Student {FirstName = "Jillian", LastName = "Begue", Major = "Fashion Design", GPA = 3.1M},
                new Student {FirstName = "Nadia", LastName = "Degeneres", Major = "Communications", GPA = 3.7M},
                new Student {FirstName = "Logan", LastName = "Norred", Major = "FedEx", GPA = 4.0M },
                new Student {FirstName = "Hannah", LastName = "Carmella", Major = "Criminal Justice", GPA = 2.4M},
                new Student {FirstName = "Warren", LastName = "Hoover", Major = "Theater", GPA = 1.6M },
                new Student {FirstName = "Coby", LastName = "Kelly", Major = "Computer Science", GPA = 3.3M},
                new Student {FirstName = "Mario", LastName = "Wardell", Major = "FedEx", GPA = 3.8                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            M},
            };
        }
    }
}
