using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            CategoryValidator cv=new CategoryValidator();
            ValidationResult validationResult = cv.Validate(p);
            if (validationResult.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var err in validationResult.Errors)
                {
                    ModelState.AddModelError(err.PropertyName, err.ErrorMessage);
                }
                return View();
            }
        }
        public IActionResult DeleteCategory(int id)
        {
            var categoryvalue=cm.GetById(id);
            cm.DeleteCategory(categoryvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category=cm.GetById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult EditCAtegory(Category p)
        {
            
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
