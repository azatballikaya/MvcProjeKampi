using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;
        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        //GenericRepository<Category> _repo = new GenericRepository<Category>();
        //public List<Category> GetAllBL()
        //{
        //    return _repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {

        //        //hata mesajı
        //    }
        //    else
        //    {
        //        _repo.Insert(p);
        //    }

        //}
        public void CategoryAdd(Category p)
        {
            _categorydal.Insert(p);
        }

        public void CategoryUpdate(Category p)
        {
            _categorydal.Update(p);
        }

        public void DeleteCategory(Category p)
        {
            _categorydal.Delete(p);
        }

        public Category GetById(int id)
        {
            return _categorydal.Get(x=>x.CategoryId== id);

        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }
       
    }
}
