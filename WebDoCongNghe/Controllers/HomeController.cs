using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDoCongNghe.Models;
namespace WebDoCongNghe.Controllers
{
    public class HomeController : Controller
    {
        private MyDB context = new MyDB();
        public ActionResult Home()
        {
            var model2 = context.SanPhams.ToList();
            return View(model2);
        }
        public PartialViewResult LoadMenuCon(string MaDmCha)
        {
            List<DanhMucSp> danhMucSps = new List<DanhMucSp>();
            danhMucSps = context.DanhMucSps.Where(x => x.MaDMCha == MaDmCha).ToList();
            ViewBag.soluong = danhMucSps.Count();
            return PartialView("LoadMenuCon", danhMucSps);
        }
        [ChildActionOnly]
        public PartialViewResult Menu()
        {
            List<DanhMucSp> danhMucSps = new List<DanhMucSp>();
            danhMucSps = context.DanhMucSps.Where(x => x.MaDMCha == null).ToList();
            return PartialView(danhMucSps);
        }

        public ActionResult ToDanhMuc(string id)
        {
            var model = context.SanPhams.Where(x => x.MaDanhMuc == id).ToList();

            return View(model);
        }

    }
}