﻿using CoreEntities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Entities
{
    public class Subject
    {
        #region Properties
        public int SubjectOID { get; set; } // This id is used by EntityFramework.
        public int Code { get; set; }
        public string Name { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        #endregion

        public Subject()
        {
            this.Code = 0;
            this.Name = string.Empty;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public Subject(int code, string name)
        {
            this.Code = code;
            this.Name = name;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public void SetCode(int code)
        {
            this.Code = code;
        }

        public int GetCode()
        {
            return this.Code;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }

        public void SetTeachers(List<Teacher> teachers)
        {
            this.Teachers = teachers;
        }

        public void SetStudents(List<Student> students)
        {
            this.Students = students;
        }

        public void AddStudent(Student student)
        {
            if (!SubjectAlreadyHasThisStudent(student))
            {
                this.Students.Add(student);
            }
            else
            {
                throw new CoreException("This student is already enrolled to this subject.");
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public override bool Equals(object obj)
        {
            if (obj is Subject)
                return this.GetCode().Equals(((Subject)obj).GetCode());
            else
                return false;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Code, this.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }        

        #region Private Methods
        private bool SubjectAlreadyHasThisStudent(Student student)
        {
            return this.Students.FirstOrDefault(s => s.GetDocumentNumber() == student.GetDocumentNumber()) != null;
        }
        #endregion
    }
}
