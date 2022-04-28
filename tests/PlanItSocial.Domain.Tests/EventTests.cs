using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Text;
using PlanItSocial.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace PlanItSocial.Domain.Tests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void TestEventCreationValid()
        {
            var name = "holiday";
            var description = "Beautiful trip to the dream destination";
            var start = new DateTime(2022, 04, 30, 12, 00, 00);
            var end = new DateTime(2022, 05, 15, 12, 00, 00);


            Event myevent = new Event();
            myevent.Name = name;
            myevent.StartTime = start;
            myevent.EndTime = end;
            myevent.Description = description;

            Assert.AreEqual(myevent.Name, name);
            Assert.AreEqual(myevent.Description, description);
            Assert.AreEqual(myevent.StartTime, start);
            Assert.AreEqual(myevent.EndTime, end);

        }


        [TestMethod]
        public void TestEventUpdateEventPass()
        {
            var name = "holiday";
            var description = "Beautiful trip to the dream destination";
            var start = new DateTime(2022, 04, 30, 12, 00, 00);
            var end = new DateTime(2022, 05, 15, 12, 00, 00);


            Event myevent = new Event();
            var myDict = new Dictionary<string, StringValues>();
            myDict.Add("Event.Name", name);
            myDict.Add("Event.Description", description);
            myDict.Add("Event.StartTime", start.ToString());
            myDict.Add("Event.EndTime", end.ToString());

            var form = new FormCollection(myDict);

            myevent.UpdateEvent(form, new Location(), new ApplicationUser());

            Assert.AreEqual(name, myevent.Name);
            Assert.AreEqual(description, myevent.Description);
            Assert.AreEqual(start, myevent.StartTime);
            Assert.AreEqual(end, myevent.EndTime);

        }
    }
}
