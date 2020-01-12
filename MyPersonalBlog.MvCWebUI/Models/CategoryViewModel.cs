using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalBlog.MvCWebUI.Models
{
    public class CategoryViewModel
    {
        public Category Category { get; set; }

        public CategoryViewModel()
        {
            this.Category = new Category();
        }
    }
}