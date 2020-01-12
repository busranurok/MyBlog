using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPersonalBlog.MvCWebUI.ViewModels
{
    public class RegisterViewModel
    {
        [DisplayName("Ad"), Required(ErrorMessage = "{0} alanı boş geçilemez!")]
        public string Firstname { get; set; }
        [DisplayName("Soyad"), Required(ErrorMessage = "{0} alanı boş geçilemez!")]
        public string Lastname { get; set; }
        [DisplayName("E-posta"), Required(ErrorMessage = "{0} alanı boş geçilemez!"), EmailAddress(ErrorMessage ="{0} alanı için geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }
        [DisplayName("Şifre"), Required(ErrorMessage = "{0} alanı boş geçilemez!")]
        public string Password { get; set; }
        [DisplayName("Şifre Tekrar"), Required(ErrorMessage = "{0} alanı boş geçilemez!"), Compare("Password", ErrorMessage ="{0} ile {1} uyuşmuyor")]
        public string RepeatPassword { get; set; }
    }
}