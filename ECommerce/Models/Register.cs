using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Register
    {
        [DisplayName("Adınız")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Soyadınız")]
        [Required]
        public string Surname { get; set; }
        [DisplayName("Kullanıcı Adınız")]
        [Required]
        public string UserName { get; set; }
        [DisplayName("Mail Adresiniz")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli Email adresi giriniz.")]
        [Required]
        public string Email { get; set; }
        [DisplayName("Şifre")]
        [Required]
        public string Password { get; set; }
        [DisplayName("Şifre Tekrar")]
        [Required]
        [Compare("Password",ErrorMessage ="Şifreleriniz uyuşmuyor.")]
        public string RePassword { get; set; }
    }
}