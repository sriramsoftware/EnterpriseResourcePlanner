﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic.Entities;
using System.Collections.Generic;
using DataAccess;

namespace UnitTesting
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void CreateSubjectWithoutParameters()
        {
            Subject subject = new Subject();

            int expectedCode = 0;
            string expectedName = string.Empty;
            List<Student> expectedStudents = new List<Student>();
            List<Teacher> expectedTeachers = new List<Teacher>();

            Assert.AreEqual(expectedCode, subject.Code);
            Assert.AreEqual(expectedName, subject.Name);
            this.CompareListsOfStudents(expectedStudents, subject.Students);
            this.CompareListsOfTeachers(expectedTeachers, subject.Teachers);
        }

        [TestMethod]
        public void CreateSubjectWithParameters()
        {
            int expectedCode = 100;
            string expectedName = "Logic";
            List<Student> expectedStudents = new List<Student>();
            List<Teacher> expectedTeachers = new List<Teacher>();

            Subject subject = new Subject(expectedCode, expectedName);

            Assert.AreEqual(expectedCode, subject.Code);
            Assert.AreEqual(expectedName, subject.Name);
            this.CompareListsOfStudents(expectedStudents, subject.Students);
            this.CompareListsOfTeachers(expectedTeachers, subject.Teachers);
        }

        [TestMethod]
        public void SubjectInstancesAreEqual()
        {
            int expectedCode = 100;
            string expectedName = "Logic";
            List<Student> expectedStudents = new List<Student>();
            List<Teacher> expectedTeachers = new List<Teacher>();

            Subject firstSubject = new Subject(100, "Logic");
            Subject secondSubject = new Subject(100, "Logic");

            Assert.IsTrue(firstSubject.Equals(secondSubject));
        }

        [TestMethod]
        public void AddSubjectToSystem()
        {
            SystemData systemData = this.GetNewSystemData();
            List<Subject> systemSubjects = systemData.GetSystemSubjects();

            Subject newSubject = new Subject(1, "Logic");
            systemSubjects.Add(newSubject);

            Assert.IsNotNull(this.FindSubjectOnSystem(newSubject.GetCode()));
        }

        public void TryToAddSubjectThatAlreadyExistsToSystem()
        {
            try
            {
                SystemData systemData = this.GetNewSystemData();
                List<Subject> systemSubjects = systemData.GetSystemSubjects();

                Subject firstTeacher = new Subject(1, "Logic");
                Subject secondTeacher = new Subject(1, "Logic");
                systemSubjects.Add(firstTeacher);
                systemSubjects.Add(secondTeacher);

                Assert.Fail();
            }
            catch (CoreException ex)
            {
                Assert.IsTrue(ex.Message.Equals("Subject already exists."));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }


        #region Extra Methods
        private void CompareListsOfStudents(List<Student> real, List<Student> toBeCompareWith)
        {
            Assert.AreEqual(real.Count, toBeCompareWith.Count);
            for (var index = 0; index < real.Count; index++)
            {
                Assert.AreEqual(real[index], toBeCompareWith[index]);
            }
        }

        private void CompareListsOfTeachers(List<Teacher> real, List<Teacher> toBeCompareWith)
        {
            Assert.AreEqual(real.Count, toBeCompareWith.Count);
            for (var index = 0; index < real.Count; index++)
            {
                Assert.AreEqual(real[index], toBeCompareWith[index]);
            }
        }

        private SystemData GetNewSystemData()
        {
            SystemData.GetInstance.Reset();
            return SystemData.GetInstance;
        }

        private Subject FindSubjectOnSystem(int code)
        {
            return SystemData.GetInstance.GetSystemSubjects().Find(x => x.GetCode() == code);
        }
        #endregion
    }
}