using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordBank.Library.Email;
using WordBank.Models;

namespace WordBank.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceiveContact([FromForm]Contact contact)
        {
            if(ModelState.IsValid)
            {
                //string content = string.Format("Name: {0}, E-mail: {1}, Subject: {2}, Message: {3}", contact.Name, contact.Email, contact.Subject, contact.Message);

                //return new ContentResult() { Content = content };

                SendEmail.SendContactMessage(contact);
                ViewBag.Message = "Message was sucessfully sented";   
                return View("Index");
            }
            else
            {
                return View("Index");
            }
            
        }

        //Get Data manually

        //public IActionResult ReceiveContact()
        //{
        //    //Post - Request.Form
        //    //GET - Request.QueryString
        //    Contact contact = new Contact();   

        //    contact.Name = Request.Form["name"];
        //    contact.Email = Request.Form["email"];
        //    contact.Subject = Request.Form["subject"];
        //    contact.Message = Request.Form["message"];

        //    string content = string.Format("Name: {0}, E-mail: {1}, Subject: {2}, Message: {3}",contact.Name,contact.Email,contact.Subject,contact.Message);

        //    return new ContentResult(){ Content = content };
        //}
    }
}
