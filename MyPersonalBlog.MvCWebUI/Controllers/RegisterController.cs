using MyPersonalBlog.Business.Concrete.Manager;
using MyPersonalBlog.Entities.Concrete;
using MyPersonalBlog.MvCWebUI.Models;
using MyPersonalBlog.MvCWebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPersonalBlog.MvCWebUI.Controllers
{
    public class RegisterController : Controller
    {
        UserManager _userManager = new UserManager();

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            //ad soyad kontrolü
            //kullanıcı eposta kontrolü
            //kayıt işlemi
            //aktivasyon epostası gönderimi
            if (ModelState.IsValid)
            {
                //veritabanındaki emaillerden biri ile kullanıcının girdiği email aynı mı?
                var user = _userManager.Get(x=> x.Email == model.Email);
                //eğer aynı ise hata döndür
                if (user!= null)
                {
                    return View("Error", new ErrorViewModal() {
                        Header = "İşlem Hatası",
                        Title = "Girmiş olduğunuz mail adresi ile mevcut hesap bulunmaktadır, lütfen başka eposta adresi girin.",
                        RedirectingUrl = "/Register/Register"
                    });
                }

                //aynı değil ise ekle
                var addedUser = new User();
                addedUser.Email = model.Email;
                addedUser.Firstname = model.Firstname;
                addedUser.IsAdmin = false;
                addedUser.Lastname = model.Lastname;
                addedUser.Password = model.Password;
                addedUser.ProfileImageFilename = "";

                _userManager.Add(addedUser);

                OkViewModel okeyViewModel = new OkViewModel()
                {
                    Title = "Kayıt Başarılı!",
                    RedirectingUrl = "/Login/Login"
                };

                okeyViewModel.Items.Add("Eposta adresinize gelen linki aktive edin!");
                return View("Ok", okeyViewModel);
            }
           

            return View(model);
        }

    }
}