using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalBlog.MvCWebUI.Models
{
    public class ArticleDetailViewModel
    {
        public Article Article { get; set; }

        public ArticleDetailViewModel()
        {
            //model tanımladığımızda article nesnesi null gelmesin diye
            this.Article = new Article();
        }
    }
}