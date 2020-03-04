using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [Required]
        [DisplayName("Stok Adeti")]
        public int Stock { get; set; }
        [Required]
        [DisplayName("Resim")]
        public string Image { get; set; }
        [Required]
        [DisplayName("Anasayfada mı")]
        public bool IsHome { get; set; }
        [Required]
        [DisplayName("Onaylı mı")]
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}