using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> List(Expression <Func<T,bool>> filter);
        List<T> List();
        List<T> List(string class1);
        List<T> List(string class1,string class2);
        T Get(Expression<Func<T,bool>> filter);
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
    }
}
