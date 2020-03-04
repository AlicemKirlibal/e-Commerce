using ECommerce.Entity;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    [Authorize(Roles ="admin")]
    public class OrderController : Controller
    {
        DataContext db = new DataContext();
        // GET: Order
        public ActionResult Index()
        {

            var orders = db.Orders.Select(i => new AdminOrderModel()
            {
                Id = i.Id,
                OrderDate = i.OrderDate,
                OrderNumber = i.OrderNumber,
                OrderState = i.OrderState,
                Count=i.OrderLines.Count,
                Total = i.Total
            }).OrderByDescending(i=>i.OrderDate).ToList();

            return View(orders);
        }
    }
}