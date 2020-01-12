using MyPersonalBlog.Business.Concrete.Manager;
using MyPersonalBlog.Entities.Concrete;
using MyPersonalBlog.MvCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPersonalBlog.MvCWebUI.Controllers
{
    public class ProfileController : Controller
    {
        UserManager _userManager = new UserManager();
        // GET: Profile
        public ActionResult ShowProfile()
        {
            var model = new UserViewModel();
            model.User = (User)Session["CurrentUser"];
            //var model = (User)Session["CurrentUser"];
            return View(model);
        }


        public ActionResult EditProfile()
        {
            var model = new UserViewModel();
            model.User = (User)Session["CurrentUser"];
            return View(model);

            //Model için ayrı bir class kullanmadığımızda yani(UserViewModel) yerine User class ını  kullandığımızda aşağıdaki kod geçerli olur
            //yukarıdaki şekilde değiştirdiğimizde cshtml de modeli ve model tanımını da değiştirmeliyiz
            //var user = (User)Session["CurrentUser"];
            //return View(user);
        }


        [HttpPost]
        public ActionResult EditProfile(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existUser = _userManager.Get(x => x.Id == model.User.Id);
                existUser.Email = model.User.Email;
                existUser.Firstname = model.User.Firstname;
                existUser.IsAdmin = true;
                existUser.Lastname = model.User.Lastname;
                existUser.Password = model.User.Password;
                existUser.ProfileImageFilename = model.User.ProfileImageFilename;
                _userManager.Update(existUser);
                Session["CurrentUser"] = existUser;
            }
            return RedirectToAction("ShowProfile", "Profile");
        }

    }
}