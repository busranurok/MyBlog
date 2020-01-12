using MyPersonalBlog.Business.Concrete.Manager;
using MyPersonalBlog.MvCWebUI.Models;
using MyPersonalBlog.MvCWebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPersonalBlog.MvCWebUI.Controllers
{
    public class LoginController : Controller
    {
        UserManager _userManager = new UserManager();

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            ErrorViewModal model = new ErrorViewModal();
            //to do:
            //1-Kullanıcı bilgileri verittabanında var mı ve doğru mu kontrol edilecek
            //2-Eğer bilgiler doğruysa session içerisinde user nesnesi tutulacak
            //3-Session doldurulduktan sonra home/indexer e yönlendirilecek
            //4-Kullanıcı bilgileri yanlış ise hata mesajı oluşturularak hata ekranına yönlendirilecek
            if (ModelState.IsValid)
            {
                var userList = _userManager.GetAll();
                var user = _userManager.Find(x => x.Email ==email && x.Password == password);
                if (user != null)
                {
                    Session["CurrentUser"] = user;
                    return RedirectToAction(actionName: "Index", controllerName: "Home");
                }

                else
                {
                    return View("Index", model);
                }

            }

            return RedirectToAction("Index", model);

        }


        public ActionResult LogOut()
        {
            Session["CurrentUser"] = null;
            return RedirectToAction(actionName:"Index", controllerName:"Home");
        }
    }
}