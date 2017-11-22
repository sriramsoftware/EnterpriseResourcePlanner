﻿using CoreEntities.Entities;
using CoreLogic.Interfaces;
using DummyPersistance;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Utilities;

namespace UnitTesting
{
    [TestClass]
    public class PaymentTest
    {
        [TestInitialize]
        public void TestInitialization()
        {
            SystemDummyData.GetInstance.Reset();
        }

        [TestMethod]
        public void GetStudentFees()
        {
            try
            {
                IStudentLogic studentOperations = DummyProvider.GetInstance.GetStudentOperations();
                IPaymentLogic paymentOperations = DummyProvider.GetInstance.GetPaymentOperations();

                var newStudent = Utility.CreateRandomStudent();
                newStudent.Fees = Utility.GenerateYearFees();
                newStudent.StudentNumber = 1;

                studentOperations.AddStudent(newStudent);

                List<Fee> studentFees = paymentOperations.GetCurrentYearFeesByStudentNumber(newStudent.StudentNumber);
                Assert.IsNotNull(studentFees);
                Assert.AreEqual(studentFees.Count, 12);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        
        [TestMethod]
        public void PayFees()
        {
            try
            {
                IStudentLogic studentOperations = DummyProvider.GetInstance.GetStudentOperations();
                IPaymentLogic paymentOperations = DummyProvider.GetInstance.GetPaymentOperations();

                var newStudent = Utility.CreateRandomStudent();
                newStudent.Fees = Utility.GenerateYearFees();
                newStudent.StudentNumber = 1;

                studentOperations.AddStudent(newStudent);

                List<Fee> feesToBePaid = newStudent.Fees.Take(3).ToList();
                paymentOperations.PayFees(feesToBePaid);

                List<Fee> studentFees = paymentOperations.GetCurrentYearFeesByStudentNumber(newStudent.StudentNumber);
                List<Fee> checkFeesPaid = studentFees.Take(3).ToList();
                foreach(var fee in checkFeesPaid)
                    Assert.IsTrue(fee.IsPaid);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
