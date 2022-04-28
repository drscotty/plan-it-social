using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanItSocial.Domain.Models;

namespace PlanItSocial.Domain.Tests
{
    [TestClass]
    public class ContactFormTests
    {
        [TestMethod]
        public void TestEmailAddressValid()
        {
            var email = "johndoe@email.com";

            var form = new ContactForm();
            form.Email = email;

            Assert.AreEqual(email, form.Email);

        }


        [TestMethod]
        public void TestContactFormCreationValid()
        {
            var email = "user@email.com";
            var name = "John Doe";
            var message = "Hello World!";

            var form = new ContactForm();
            form.Email = email;
            form.Name = name;
            form.Message = message;

            Assert.AreEqual(email, form.Email);
            Assert.AreEqual(name, form.Name);
            Assert.AreEqual(message, form.Message);
        }


    }
}
