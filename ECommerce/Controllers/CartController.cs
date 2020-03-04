using ECommerce.Entity;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();
            if (product!=null)
            {
                GetCart().AddProduct(product,1);
            }
            return RedirectToAction("Index");
        }
        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();
            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {
            //sessionun(her kullanıcıya özel oluşturulan kartı sakladım) içindeki cartı alıp oluşturduğum nesneye attım ve ifte check ettim boşsa diye
            var cart = (Cart)Session["Cart"];

            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }

        public ActionResult Checkout()
        {
            return View(new Shipping());
        }
        [HttpPost]
        public ActionResult Checkout(Shipping shipping)
        {
            var cart = GetCart();

            if (cart.CartLines.Count==0)
            {
                ModelState.AddModelError("UrunYokError", "Sepetinizde ürün bulunamamktadır.");
            }
            if (ModelState.IsValid)
            {
                SaveOrder(cart, shipping);
                cart.Clear();
                return View("Completed",shipping);
            }
            else
            {
                return View(shipping);
            }
        }
        private void SaveOrder(Cart cart, Shipping shipping)
        {
            var order = new Order();

            order.OrderNumber = "X" + (new Random()).Next(11111, 99999);
            order.Total = cart.Total();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.UserName = User.Identity.Name;

            order.AdresBasligi = shipping.AdresBasligi;
            order.Adres = shipping.Adres;
            order.Sehir = shipping.Sehir;
            order.Semt = shipping.Semt;
            order.Mahalle = shipping.Mahalle;
            order.PostaKodu = shipping.PostaKodu;

            order.OrderLines = new List<OrderLine>();

            foreach (var pr in cart.CartLines)
            {
                var orderline = new OrderLine();
                orderline.Quantity = pr.Quantity;
                orderline.Price =pr.Quantity* pr.Product.Price;
                orderline.ProductId = pr.Product.Id;

                order.OrderLines.Add(orderline);
            }
            db.Orders.Add(order);
            db.SaveChanges();



        }
    }
}