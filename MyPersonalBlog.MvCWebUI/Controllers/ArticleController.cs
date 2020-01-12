using MyPersonalBlog.Business.Concrete.Manager;
using MyPersonalBlog.Entities.Concrete;
using MyPersonalBlog.MvCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MyPersonalBlog.MvCWebUI.Controllers
{
    public class ArticleController : Controller
    {
        ArticleManager _articleManager = new ArticleManager();
        CategoryManager _categoryManager = new CategoryManager();
        LikedManager _likedManager = new LikedManager();
        DisplayedManager _displayedManager = new DisplayedManager();
        // GET: Article
        public ActionResult ListArticle()
        {
            var model = _articleManager.GetAll();
            return View(model);
        }


        public JsonResult LikeThis(int id)
        {
            var article = _articleManager.GetAll().FirstOrDefault(x => x.Id == id);
            Liked liked = new Liked();
            liked.ArticleId = id;
            liked.ArticleLikedDate = DateTime.Now;
            _likedManager.Add(liked);

            return Json(null,JsonRequestBehavior.AllowGet);
        }





        public ActionResult AddArticle(int id = 0)
        {
            var model = new ArticleDetailViewModel();

            CategoryManager categoryManager = new CategoryManager();
            var categories = categoryManager.GetAll();
            ViewBag.Categories = categories;
            if (id != 0)
            {
                var article = _articleManager.Get(a => a.Id == id);
                model.Article = article;
            }
            return View(model);
        }



        [HttpPost]
        public ActionResult AddArticle(ArticleDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                //veritabanında veri olmadığı için bir şey getirilmiyor bu yüzden direkt bu şekilde yazılır
                model.Article.ArticleCreatedUserId = ((User)Session["CurrentUser"]).Id;
                model.Article.ArticleCreatedDate = DateTime.Now;
                model.Article.ArticleModifiedDate = DateTime.Now;
                model.Article.ArticleModifiedUserId= ((User)Session["CurrentUser"]).Id;
                model.Article.User= ((User)Session["CurrentUser"]);
                new ArticleManager().Add(model.Article);
            }

            else
            {
                ErrorViewModal errorViewModel = new ErrorViewModal()
                {
                    Title = "Model Yanlış!",
                    RedirectingUrl = "/Article/AddArticle"
                };

                return View("Error", errorViewModel);
            }
            return RedirectToAction("ListArticle","Article");
        }

        public ActionResult ArticleDetail(int id)
        {
            var model = new ArticleDetailViewModel();
            var article= _articleManager.Get(x => x.Id == id);
            Displayed disp = new Displayed();
            disp.ArticleId = article.Id;
            disp.ArticleDisplayedDate = DateTime.Now;
            _displayedManager.Add(disp);

            model.Article = article;

            return View(model);
        }


        public ActionResult EditArticle(int id)
        {
            var model = new ArticleDetailViewModel();
            model.Article = _articleManager.Get(x => x.Id == id);
            ViewBag.Categories = _categoryManager.GetAll();
            return View(model);
        }

        [HttpPost]
        public ActionResult EditArticle(ArticleDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var article = _articleManager.Get(x => x.Id == model.Article.Id);
                article.ArticleContent = model.Article.ArticleContent;
                article.ArticleModifiedDate = DateTime.Now;
                article.ArticleTitle = model.Article.ArticleTitle;
                article.CategoryId = model.Article.CategoryId;
                article.ImageURL = model.Article.ImageURL;
                article.IsDraft = model.Article.IsDraft;
                article.ArticleModifiedUserId=((User)Session["CurrentUser"]).Id;
                _articleManager.Update(article);
            }
            return RedirectToAction("ListArticle", "Article");
        }


            public ActionResult DeleteArticle(int id)
        {
            var model = _articleManager.Get(a => a.Id == id);
            _articleManager.Delete(model);
            return RedirectToAction("ListArticle");
        }
    }
}