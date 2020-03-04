using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public  List<Product> Products { get; set; }
    }
}