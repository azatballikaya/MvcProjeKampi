using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;
        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }
        public Heading GetById(int id)
        {
           return _headingDal.Get(x => x.HeadingId == id);
        }

        public List<Heading> GetList()
        {
           return _headingDal.List();
        }
        public List<Heading> GetList(string class1)
        {
            return _headingDal.List(class1);
        }
        public List<Heading> GetList(string class1,string class2)
        {
            return _headingDal.List(class1,class2);
        }


        public void HeadingAdd(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
