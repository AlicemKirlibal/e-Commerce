using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerce.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){Name="Erkek",Description="Erkek ürünleri içerir"},
               new Category(){Name="Kadın",Description="Kadın ürünleri içerir"},
                new Category(){Name="Erkek Çocuk ",Description="Erkek çocuk ürünleri içerir"},
                new Category(){Name="Kız Çocuk",Description="Kız çocuk ürünleri içerir"},
                new Category(){Name="Outlet",Description="Outlet ürünleri içerir"}
            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            List<Product> products = new List<Product>()
            {
                new Product(){Name="Pierre Cardin",Price=112, IsApproved=true, Stock=115, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
                new Product(){Name="US Polo Assn",Price=113, IsApproved=true, Stock=144, Description=" Hırka G021GL0TH.000.973543", CategoryId=2,IsHome=true,Image="4.jpg"},
                new Product(){Name="Sateen Men",Price=211, IsApproved=true, Stock=117, Description=" Hırka G021GL0TH.000.973543", CategoryId=3,IsHome=true,Image="11.jpg"},
                new Product(){Name="Avva",Price=91, IsApproved=true, Stock=19, Description=" Hırka G021GL0TH.000.973543", CategoryId=4,IsHome=true,Image="14.jpg"},
                new Product(){Name="Little Cup",Price=31, IsApproved=true, Stock=18, Description=" Hırka G021GL0TH.000.973543", CategoryId=4,IsHome=true,Image="14.jpg"},
                new Product(){Name="Sateen Men",Price=149, IsApproved=false, Stock=17, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="4.jpg"},
                new Product(){Name="Avva",Price=113, IsApproved=false, Stock=16, Description=" Hırka G021GL0TH.000.973543", CategoryId=2,IsHome=false,Image="2.jpg"},
                new Product(){Name="Little Cup",Price=165, IsApproved=false, Stock=15, Description=" Hırka G021GL0TH.000.973543", CategoryId=3,IsHome=false,Image="12.jpg"},
                new Product(){Name="Avva",Price=1216, IsApproved=true, Stock=14, Description=" Hırka G021GL0TH.000.973543", CategoryId=4,IsHome=false,Image="13.jpg"},
                new Product(){Name="Little Cup",Price=18, IsApproved=true, Stock=13, Description=" Hırka G021GL0TH.000.973543", CategoryId=4,IsHome=false,Image="13.jpg"},
                new Product(){Name="US Polo Assn",Price=99, IsApproved=true, Stock=12, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=false,Image="4.jpg"},
                 new Product(){Name="Pierre Cardin",Price=198, IsApproved=true, Stock=110, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
                  new Product(){Name="Pierre Cardin",Price=172, IsApproved=true, Stock=1, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
                   new Product(){Name="Pierre Cardin",Price=134, IsApproved=true, Stock=115, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
                    new Product(){Name="Pierre Cardin",Price=144, IsApproved=true, Stock=115, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
                     new Product(){Name="Pierre Cardin",Price=162, IsApproved=true, Stock=115, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
                      new Product(){Name="Pierre Cardin",Price=198, IsApproved=true, Stock=15, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
                       new Product(){Name="Pierre Cardin",Price=98, IsApproved=true, Stock=115, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
                        new Product(){Name="Pierre Cardin",Price=134, IsApproved=true, Stock=115, Description="Erkek Hırka G021GL0TH.000.973543", CategoryId=1,IsHome=true,Image="3.jpg"},
 new Product(){Name="Sateen Men",Price=211, IsApproved=true, Stock=117, Description=" Hırka G021GL0TH.000.973543", CategoryId=3,IsHome=true,Image="11.jpg"},
  new Product(){Name="Sateen Men",Price=211, IsApproved=true, Stock=117, Description=" Hırka G021GL0TH.000.973543", CategoryId=3,IsHome=true,Image="11.jpg"},
   new Product(){Name="Sateen Men",Price=211, IsApproved=true, Stock=117, Description=" Hırka G021GL0TH.000.973543", CategoryId=3,IsHome=true,Image="11.jpg"},
    new Product(){Name="Sateen Men",Price=211, IsApproved=true, Stock=117, Description=" Hırka G021GL0TH.000.973543", CategoryId=3,IsHome=true,Image="11.jpg"},
     new Product(){Name="Sateen Men",Price=211, IsApproved=true, Stock=117, Description=" Hırka G021GL0TH.000.973543", CategoryId=3,IsHome=true,Image="11.jpg"},
      new Product(){Name="Sateen Men",Price=211, IsApproved=true, Stock=117, Description=" Hırka G021GL0TH.000.973543", CategoryId=3,IsHome=true,Image="11.jpg"},
       new Product(){Name="Avva",Price=113, IsApproved=false, Stock=16, Description=" Hırka G021GL0TH.000.973543", CategoryId=2,IsHome=false,Image="4.jpg"},
        new Product(){Name="Avva",Price=113, IsApproved=false, Stock=16, Description=" Hırka G021GL0TH.000.973543", CategoryId=2,IsHome=false,Image="4.jpg"},
         new Product(){Name="Avva",Price=113, IsApproved=false, Stock=16, Description=" Hırka G021GL0TH.000.973543", CategoryId=2,IsHome=false,Image="4.jpg"},
          new Product(){Name="Avva",Price=113, IsApproved=false, Stock=16, Description=" Hırka G021GL0TH.000.973543", CategoryId=2,IsHome=false,Image="4.jpg"},
           new Product(){Name="Avva",Price=1216, IsApproved=true, Stock=14, Description=" Hırka G021GL0TH.000.973543", CategoryId=4,IsHome=false,Image="13.jpg"},
           new Product(){Name="Avva",Price=1216, IsApproved=true, Stock=14, Description=" Hırka G021GL0TH.000.973543", CategoryId=4,IsHome=false,Image="13.jpg"},
           new Product(){Name="Avva",Price=1216, IsApproved=true, Stock=14, Description=" Hırka G021GL0TH.000.973543", CategoryId=4,IsHome=false,Image="13.jpg"},
           new Product(){Name="Avva",Price=1216, IsApproved=true, Stock=14, Description=" Hırka G021GL0TH.000.973543", CategoryId=4,IsHome=false,Image="13.jpg"},

            };
            foreach (var item in products)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}