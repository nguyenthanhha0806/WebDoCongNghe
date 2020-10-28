using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDoCongNghe.Models;

namespace WebDoCongNghe.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        private MyDB context = new MyDB();
        public ActionResult Index()
        {
            var cart = (Cart)Session["CartSession"];
            if (cart == null)
            {
                cart = new Cart();
            }

            return View(cart);
        }



        public ActionResult AddItem(string id, string returnURL)
        {
            var product = context.SanPhams.Find(id);
            var cart = (Cart)Session["CartSession"];
            if (cart != null)
            {
                cart.AddItem(product, 1);
                //Gán vào session
                Session["CartSession"] = cart;
            }
            else
            {
                //tạo mới đối tượng cart item
                cart = new Cart();
                cart.AddItem(product, 1);
                //Gán vào session[IUYT--
                Session["CartSession"] = cart;
            }

            if (string.IsNullOrEmpty(returnURL))
            {
                return RedirectToAction("Index");
            }
            return Redirect(returnURL);
        }
        //public ActionResult Add(SanPham sp)
        //{
        //    if (Session["cart"] == null)
        //    {
        //        List<SanPham> li = new List<SanPham>();
        //        li.Add(sp);
        //        ViewBag.cart = li.Count();
        //        Session["count"] = 1;
        //    }
        //    else
        //    {
        //        List<SanPham> li = (List<SanPham>)Session["cart"];
        //        li.Add(sp);
        //        ViewBag.cart = li.Count();
        //        Session["count"] = Convert.ToInt32(Session["count"]) + 1;
        //    }
        //    return RedirectToAction("Home", "Home");
        //}
        //public ActionResult Thanhtoan()
        //{

        //    return View((List<SanPham>)Session["cart"]);

        //}
        //public ActionResult Thanhtoan()
        //{

        //    return View();

        //}

        //public ActionResult Remove(SanPham mob)
        //{
        //    List<SanPham> li = (List<SanPham>)Session["cart"];
        //    //li.RemoveAll(x => x.slno == mob.slno);
        //    Session["cart"] = li;
        //    Session["count"] = Convert.ToInt32(Session["count"]) - 1;
        //    return RedirectToAction("Index", "Cart");
        //    //return View();
        //}
    }
}