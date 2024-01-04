using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        GenericRepository<Heading> gr = new GenericRepository<Heading>();
        GenericRepository<Writer> gr2 = new GenericRepository<Writer>();
        public IActionResult Index()
        {
            ViewBag.CategoryNumber = cm.GetList().Count();
            ViewBag.SoftwareHeadings = gr.List(x=>x.CategoryId==9).Count();
            ViewBag.DoesHaveA = gr2.List(x => x.WriterName.Contains("a")).Count();
           // ViewBag.MaxHeading=cm.GetList(x=>x.ca)
            return View();
        }
    }
}
