using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace DentalClinicLandingPage.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mail(string message)
        {        
            MailMessage mail = new MailMessage();
            mail.To.Add("yedige21@gmail.com");
            mail.From = new MailAddress("yedige21@gmail.com");
            mail.Subject = "sub"; // Тема
            //mail.Body = "Попытка отправки почты";
            mail.Body = message;


            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Credentials = new System.Net.NetworkCredential
                 ("yedige21@gmail.com", "пароль"); // ***use valid credentials***
            smtp.Port = 587;

            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);

            return View();         
        }
    }
}