using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TELERIK_KPK_UnitTesting.TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestTheConstructorCourseName()
        {
            List<Student> myColeges = new List<Student>(){ 
            new Student("stoqn",20010),
            new Student("lol", 20000)
            };
            Course myCourse = new Course("PHP", myColeges);
            Assert.AreEqual("PHP", myCourse.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAllStudentsHaveUniqueNumber()
        {
            List<Student> myColeges = new List<Student>(){ 
            new Student("stoqn",20010),
            new Student("lol", 20010)
            };
            Course myCourse = new Course("PHP", myColeges);
        }

        [TestMethod]
        public void TestAddStudent()
        {
            List<Student> myColeges = new List<Student>(){ 
            new Student("stoqn",20011),
            new Student("lol", 20010)
            };

            Course myCourse = new Course("PHP", myColeges);
            Student newStudent = new Student("Dobri - kranista", 20012);

            myCourse.AddStudent(newStudent);
            int getLastStudentNumber = myCourse.StudentsInTheCourse.Count - 1;
            Assert.AreEqual("Dobri - kranista", myCourse.StudentsInTheCourse[getLastStudentNumber].Name);
        }

        [TestMethod]
        public void TestRemoveStudend()
        {
            Student testStudent = new Student("Jack the ripper", 20012);
            List<Student> myColeges = new List<Student>(){ 
            new Student("stoqn",20011),
            new Student("lol", 20010),
            };

            Course myCourse = new Course("PHP", myColeges);
            myCourse.AddStudent(testStudent);
            myCourse.RemoveStudent(testStudent);

            bool isThereThatStudent = false;
            foreach (var student in myCourse.StudentsInTheCourse)
            {
                if (student.UniqueNumber == testStudent.UniqueNumber)
                {
                    isThereThatStudent = true;
                }
            }

            Assert.AreEqual(false, isThereThatStudent);
            Assert.AreEqual(2, myCourse.StudentsInTheCourse.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveStudendIfThereNoSuchStudent()
        {
            Student testStudent = new Student("Jack the ripper", 20012);
            List<Student> myColeges = new List<Student>(){ 
            new Student("stoqn",20011),
            new Student("lol", 20010),
            };

            Course myCourse = new Course("PHP", myColeges);
            myCourse.RemoveStudent(testStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestReachLimitOfTheCourse()
        {
            List<Student> myColeges = new List<Student>(){ 
            new Student("stoqn",20010),
            new Student("lol", 20000)
            };
            uint uniqueNumber = 30000;
            Course myCourse = new Course("PHP", myColeges);
            for (int i = 0; i < 29; i++)
            {
                uniqueNumber++;
                Student newStudent = new Student("ivane", uniqueNumber);
                myCourse.AddStudent(newStudent);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorMoreStudentsSignUpThenMaximum()
        {
            List<Student> myColeges = new List<Student>(){ 
            new Student("stoqn",20010),
            new Student("lol", 20000)
            };
            uint uniqueNumber = 30000;
            for (int i = 0; i < 29; i++)
            {
                uniqueNumber++;
                Student newStudent = new Student("ivane", uniqueNumber);
                myColeges.Add(newStudent);
            }
            Course myCourse = new Course("PHP", myColeges);
        }
    }
}
