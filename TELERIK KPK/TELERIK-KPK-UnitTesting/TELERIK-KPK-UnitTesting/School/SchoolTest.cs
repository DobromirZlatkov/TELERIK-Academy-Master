﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TELERIK_KPK_UnitTesting
{
    [TestClass]
    public class SchoolBulgTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfNotAllStudentsInSchoolHaveUniqueNumber()
        {
            List<Student> myColegesInPhp = new List<Student>(){ 
            new Student("stoqn",20010),
            new Student("lol", 20000)
            };
            List<Student> myColegesInJava = new List<Student>(){ 
            new Student("stoqn",20011),
            new Student("lol", 20002)
            };
            List<Student> myColegesInKIlling = new List<Student>(){ 
            new Student("stoqn",20003),
            new Student("lol", 20002)
            };
            Course myCoursePhp = new Course("PHP", myColegesInPhp);
            Course myCourseJava = new Course("Java", myColegesInJava);
            Course myCourseKilling = new Course("Killing", myColegesInKIlling);

            List<Course> myAllCourses = new List<Course>()
            {
               myCoursePhp,
               myCourseJava,
               myCourseKilling
            };
            School mySchool = new School(myAllCourses);
        }

    }
}
