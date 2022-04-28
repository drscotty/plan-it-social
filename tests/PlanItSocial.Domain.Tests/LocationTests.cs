using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanItSocial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanItSocial.Domain.Tests
{
    [TestClass]
    public class LocationTests
    {

        [TestMethod]
        public void TestLocationCreationValid()
        {
            var name = "home";

            var loc = new Location();
            loc.Name = name;

            Assert.AreEqual(name, loc.Name);
        }


        [TestMethod]
        public void TestLocationNameTypeValid()
        {
            var name = "home";

            var loc = new Location();
            loc.Name = name;

            Assert.IsInstanceOfType(loc.Name, typeof(String));
        }

    }
}
