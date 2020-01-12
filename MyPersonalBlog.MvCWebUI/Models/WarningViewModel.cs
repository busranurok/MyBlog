using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalBlog.MvCWebUI.Models
{
    public class WarningViewModel : NotifyViewModelBase<string>
    {
        public WarningViewModel()
        {
            Title = "Uyarı!";
        }
    }
}