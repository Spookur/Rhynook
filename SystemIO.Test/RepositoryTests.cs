using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using StudentManager.Data;
using StudentManager.Data.Models;
using StudentManager;
using System.IO;

namespace SystemIO.Test
{
    [TestFixture]
    public class RepositoryTests
    {
        private const string _filePath = @"C:\Data\StudentManager\StudentTest.txt";
        private const string _originalData = @"C:\Data\StudentManager\StudentTestSeed.txt";

        [SetUp]
        public void Setup()
        {
            if(File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }

        [Test]
        public void CanReadDataFromFile()
        {
            StudentRepository repo = new StudentRepository(_filePath);

            List<Student> students = repo.List();

            Assert.AreEqual(4, students.Count());

            Student check = students[2];

            Assert.AreEqual("Jane", check.FirstName);
            Assert.AreEqual("Doe", check.LastName);
            Assert.AreEqual("Computer Science", check.Major);
            Assert.AreEqual(4.0M, check.GPA);
        }

        [Test]
        public void CanAddStudentToFile()
        {
            StudentRepository repo = new StudentRepository(_filePath);

            Student newStudent = new Student();
            newStudent.FirstName = "Testy";
            newStudent.LastName = "Tester";
            newStudent.Major = "Research";
            newStudent.GPA = 3.2M;

            repo.Add(newStudent);

            List<Student> students = repo.List();

            Assert.AreEqual(5, students.Count());

            Student check = students[4];

            Assert.AreEqual("Testy", check.FirstName);
            Assert.AreEqual("Tester", check.LastName);
            Assert.AreEqual("Research", check.Major);
            Assert.AreEqual(3.2M, check.GPA);
        }
    }
}
