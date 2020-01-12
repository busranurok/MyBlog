using MyPersonalBlog.Business.Concrete.Manager;
using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyPersonalBlog.MvCWebUI.Controllers
{
    public class HomeController : Controller
    {
        ArticleManager _articleManager = new ArticleManager();
        JobExperienceManager _jobExperienceManager = new JobExperienceManager();
        LikedManager _likedManager = new LikedManager();

        //public ActionResult Index(string routeModelStr)
        //{
        //    List<Article> model;
        //    if (!string.IsNullOrEmpty(routeModelStr))
        //    {
        //        model = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Article>>(routeModelStr);
        //    }
        //    else
        //    {
        //        model= _articleManager.GetAll();
        //    }
        //    return View(model.OrderByDescending(x => x.ArticleModifiedDate).ToList());
        //}

        public ActionResult Index(List<Article> articles)
        {
            List<Article> model;
            if (articles!=null && articles.Count>0)
            {
                model = articles;
            }
            else
            {
                model = _articleManager.GetAll();
            }
            return View(model.Where(x=> x.IsDraft == false).OrderByDescending(x => x.ArticleModifiedDate).ToList());
        }

        public ActionResult About()
        {
            var model = _jobExperienceManager.GetAll();
            return View(model);
        }

        public ActionResult ByCategory(int? id)
        {
            List<Article> model;
            if (id == 0 || id==null)
            {
                model = _articleManager.GetAll();
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                model = _articleManager.GetAll(x => x.CategoryId == id);
            }


            if (model == null)
            {
                return new HttpNotFoundResult();
                //return RedirectToActon("Index","Home");
            }
            return View("Index", model.Where(x => x.IsDraft == false).OrderByDescending(x => x.ArticleModifiedDate).ToList());
            //return RedirectToAction("Index", "Home", new { routeModelStr = Newtonsoft.Json.JsonConvert.SerializeObject(model) });
        }
    }
}