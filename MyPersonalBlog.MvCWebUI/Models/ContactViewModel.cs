using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalBlog.MvCWebUI.Models
{
    public class ContactViewModel
    {
        public Contact Contact { get; set; }

        public ContactViewModel()
        {
            this.Contact = new Contact();
        }
    }
}