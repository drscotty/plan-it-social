using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanItSocial.Domain.Models;
using System.Net.Mail;

namespace PlanItSocial.Controllers
{
    public class ContactFormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactForm form)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(form.Email);//Email which you are getting 
                                                         //from contact us page 
                    msz.To.Add("glennbagwell@gmail.com");//Where mail will be sent 
                    msz.Subject = form.Subject;
                    msz.Body = form.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                    ("<your-email>@gmail.com", "password");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $"Sorry we are facing problems here {ex.Message}";
                }
            }

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}