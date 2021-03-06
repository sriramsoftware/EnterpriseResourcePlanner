﻿using CoreEntities.Entities;
using CoreEntities.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class LocationTest
    {
        [TestMethod]
        public void CreateLocation()
        {
            double latitud = 22;
            double longitud = -2.2;
            Location location = new Location(latitud, longitud);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ThrowInvalidFormatWhenTrySetInvalidLatitud()
        {
            try
            {
                double latitud = 222;
                double longitud = -2.2;
                Location location = new Location(latitud, longitud);

                Assert.Fail();
            }
            catch (CoreException ex)
            {
                Assert.IsTrue(ex.Message.Equals("Invalid latitud format."));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ThrowInvalidFormatWhenTrySetInvalidLongitud()
        {
            try
            {
                double latitud = 22;
                double longitud = -222.25556;
                Location location = new Location();
                location.SetLatitud(latitud);
                location.SetLongitud(longitud);

                Assert.Fail();
            }
            catch (CoreException ex)
            {
                Assert.IsTrue(ex.Message.Equals("Invalid longitud format."));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LocationToString()
        {
            double latitud = 22;
            double longitud = -1.25556;
            Location location = new Location(latitud, longitud);

            string expectedString = string.Format("({0}, {1})", latitud, longitud);
            string actualString = location.ToString();
            Assert.AreEqual(actualString, expectedString);
        }
    }
}
