using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TELERIK_KPK_UnitTesting
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestTheConstructorStudentName()
        {
            Student newStudent = new Student("ivan", 10001);
            Assert.AreEqual("ivan", newStudent.Name);
        }

        [TestMethod]
        public void TestTheConstructorStudentUniqueNumber()
        {
            Student newStudent = new Student("ivan", 20020);
            Assert.AreEqual(20020U, newStudent.UniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorStudentNameEmpty()
        {
            Student newStudent = new Student("", 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorStudentNameNull()
        {
            Student newStudent = new Student(null, 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorStudentUniqueNumberInBoundary()
        {
            Student newStudent = new Student("Kocho", 100);
        }
    }
}
