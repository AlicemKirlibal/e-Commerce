using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Login
    {
        [DisplayName("Kullanıcı Adınız")]
        [Required]
        public string UserName { get; set; }
  
        [DisplayName("Şifre")]
        [Required]
        public string Password { get; set; }

        [DisplayName("Beni Hatırla")]
        [Required]
        public bool RememberMe { get; set; }
    }
}