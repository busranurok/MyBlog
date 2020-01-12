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
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager();
        // GET: Category
        public ActionResult ListCategory()
        {
            var model = _categoryManager.GetAll();
            return View(model);
        }


        public ActionResult AddCategory(int id = 0)
        {
            var model = new CategoryViewModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult AddCategory(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Category.CategoryCreatedUserId = ((User)Session["CurrentUser"]).Id;
                model.Category.CategoryCreatedDate = DateTime.Now;
                model.Category.CategoriModifiedDate = DateTime.Now;
                model.Category.CategoryModifiedUserId = ((User)Session["CurrentUser"]).Id;
                model.Category.User = ((User)Session["CurrentUser"]);
                new CategoryManager().Add(model.Category);
            }

            else
            {
                ErrorViewModal errorViewModel = new ErrorViewModal()
                {
                    Title = "Model Yanlış!",
                    RedirectingUrl = "/Category/AddCategory"
                };

                return View("Error", errorViewModel);
            }
            return RedirectToAction("ListCategory", "Category");
        }



        public ActionResult EditCategory(int id)
        {
            var model = new CategoryViewModel();
            model.Category = _categoryManager.Get(x => x.Id == id);
            return View(model);
        }


        [HttpPost]
        public ActionResult EditCategory(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = _categoryManager.Get(x => x.Id == model.Category.Id);
                category.CategoryDescription = model.Category.CategoryDescription;
                category.CategoriModifiedDate = DateTime.Now;
                category.CategoryTitle = model.Category.CategoryTitle;
                category.CategoryModifiedUserId = ((User)Session["CurrentUser"]).Id;
                _categoryManager.Update(category);
            }
            return RedirectToAction("ListCategory", "Category");
        }



        public ActionResult DeleteCategory(int id)
        {
            var model = _categoryManager.Get(m=> m.Id == id);
            _categoryManager.Delete(model);
            return RedirectToAction("ListCategory");
        }

    }
}