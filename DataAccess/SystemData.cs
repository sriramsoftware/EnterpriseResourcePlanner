﻿using CoreEntities.Entities;
using CoreEntities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SystemData
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private List<Subject> subjects;
        private List<Vehicle> vehicles;

        #region Singleton
        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado.
        private static readonly Lazy<SystemData> instance = new Lazy<SystemData>(() => new SystemData());
        private SystemData()
        {
            this.teachers = new List<Teacher>();
            this.subjects = new List<Subject>();
            this.students = new List<Student>();
            this.vehicles = new List<Vehicle>();
        }
        public static SystemData GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        #endregion

        public void Reset()
        {
            this.teachers.Clear();
            this.subjects.Clear();
            this.students.Clear();
            this.vehicles.Clear();
        }        

        public List<Teacher> GetTeachers()
        {
            return this.teachers;
        }
        public List<Subject> GetSubjects()
        {
            return this.subjects;
        }
        public List<Student> GetStudents()
        {
            return this.students;
        }

        public List<Vehicle> GetVehicles()
        {
            return this.vehicles;
        }
    }
}