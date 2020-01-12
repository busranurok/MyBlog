using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalBlog.MvCWebUI.Models
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel()
        {
            this.User = new User();
        }
    }
}