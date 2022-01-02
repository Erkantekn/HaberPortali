using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsPortal.Models;
using NewsPortal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Controllers
{
    public  class HomeController : Controller
    {
        private PortalDbContext db;
        public HomeController(PortalDbContext context)
        {
            db = context;
        }
        public ViewResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            //son yayınlanan 4 haber slider için seçiliyor
            model.SliderNews = db.News.OrderBy(x => x.PublishDate).Take(4).ToList();
            //rastgele 10 haber seçiliyor
            model.RandomNews = db.News.OrderBy(x => Guid.NewGuid()).Take(8).ToList();
            //layout için model dolduruluyor
            var layoutModel = new LayoutModel<IndexViewModel> { PageModel = model, Categories = db.Categories.ToList() };
            return View(layoutModel);
        }
        public ActionResult Category(int? id)
        {
            if (id != null)
            {
                var model = db.News.Where(x => x.Category.CategoryID == id).ToList();
                //layout için model dolduruluyor
                var layoutModel = new LayoutModel<List<News>> { PageModel = model, Categories = db.Categories.ToList() };
                return View(layoutModel);
            }
            return RedirectToAction("Index");
        }
        public ActionResult GetDetail(int? id)
        {
            if (id != null)
            {
                var model = db.News.Where(x => x.NewsID == id).FirstOrDefault();
                //layout için model dolduruluyor
                var layoutModel = new LayoutModel<News> { PageModel = model, Categories = db.Categories.ToList() };
                return View(layoutModel);
            }
            return RedirectToAction("Index");
        }

    }
}
