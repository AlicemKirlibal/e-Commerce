using ECommerce.Entity;
using ECommerce.Identity;
using ECommerce.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class AccountController : Controller
    {
        private DataContext db = new DataContext();


        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> roleManager;
        public AccountController()
        {
            //managerlerin store lara ihtiyacı oladuğu için oluşturdum..
           var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            userManager = new UserManager<ApplicationUser>(userStore);

           var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            roleManager = new RoleManager<ApplicationRole>(roleStore);
        }
      

        public ActionResult Index()
        {
            var orders = db.Orders.Where(i => i.UserName == User.Identity.Name).Select(i => new UserOrderModel()
            {
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                Total = i.Total
            }).OrderByDescending(i=>i.OrderDate).ToList();

            return View(orders);

        }
        // GET: Acoount
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.UserName = model.UserName;

                IdentityResult result = userManager.Create(user, model.Password);
                if (result.Succeeded)
                {
                    if (roleManager.RoleExists("user"))
                    {
                        userManager.AddToRole(user.Id, "user");
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı kayıt edilemedi.");
                }
            }
            return View(model);
        }
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = userManager.Find(model.UserName, model.Password);
                if (user!=null)
                {
                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = userManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;
                    authManager.SignIn(authProperties, identityclaims);

                    if (!string.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["message"] = "Kayıtlı kullanıcı bulunamadı";
                }
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}