using MyPersonalBlog.Business.Concrete.Manager;
using MyPersonalBlog.MvCWebUI.Models;
using MyPersonelBlog.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MyPersonalBlog.MvCWebUI.Controllers
{
    public class ContactController : Controller
    {
        ContactManager _contactManager = new ContactManager();
        MailHelper email = new MailHelper();

        // GET: Contact
        //[Route("hakkimda")]
        public ActionResult Index()
        {
            return View();
        }

        //to do:
        //aldığımız contact nesnesindeki verileri kendi mail adresinden () 

        [HttpPost]
        public ActionResult Index(ContactViewModel model)
        {
           

            if (ModelState.IsValid)
            {
                try
                {
                    var contact = _contactManager.Add(model.Contact);
                    var body = new StringBuilder();
                    body.AppendLine("Ad: " + contact.Firstname);
                    body.AppendLine("Soyad: " + contact.Lastname);
                    body.AppendLine("E-Mail Adresi: " + contact.Email);
                    body.AppendLine("Konu: " + contact.TopicTitle);
                    body.AppendLine("Mesaj: " + contact.Message);
                    MailHelper.SendMail(body.ToString(), "", contact.TopicTitle, false);
                    return RedirectToAction(actionName:"Index",controllerName:"Home");
                }

                catch (Exception exception)
                {
                    return RedirectToAction(actionName: "Index", controllerName: "Error", routeValues: new { message = "Sistemsel bir hata oluştu" });
                }
            }

            return RedirectToAction(actionName: "Index", controllerName: "Error", routeValues: new { message = "Bilgileri eksik girdiniz!" });
        }
    }
}