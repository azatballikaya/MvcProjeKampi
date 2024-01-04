using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public Writer GetById(int id)
        {
            return _writerDal.Get(x=>x.WriterId==id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public void WriterAdd(Writer p)
        {
            _writerDal.Insert(p);
        }

        public void WriterDelete(Writer p)
        {
            _writerDal.Delete(p);
        }

        public void WriterUpdate(Writer p)
        {
            _writerDal.Update(p);
        }
    }
}
