using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm=new CategoryManager(new EfCategoryDal());
        WriterManager wm=new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            var headingValues = hm.GetList("Category","Writer");
            return View(headingValues);
        }
        [HttpGet]
        public IActionResult AddHeading()
        {
            List<SelectListItem> categories = (from x in cm.GetList()
                                         select new SelectListItem
                                         {
                                             Text=x.CategoryName,
                                             Value=x.CategoryId.ToString(),
                                         }).ToList();
            List<SelectListItem> writer = (from x in wm.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.WriterName + " "+ x.WriterSurname,
                                               Value = x.WriterId.ToString(),
                                           }).ToList();
            ViewBag.Categories=categories;
            ViewBag.Writer=writer;
            return View();
        }
        [HttpPost]
        public IActionResult AddHeading(Heading p)
        {
            hm.HeadingAdd(p);
            return RedirectToAction("Index");

        }
      
    }
}
