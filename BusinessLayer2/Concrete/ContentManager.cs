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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }
        public void ContentAdd(Content p)
        {
            _contentDal.Insert(p);
        }

        public void ContentDelete(Content p)
        {
            _contentDal.Delete(p);
        }

        public void ContentUpdate(Content p)
        {
            _contentDal.Update(p);
        }

        public Content GetById(int id)
        {
            return _contentDal.Get(x=>x.ContentId==id);
        }

        public List<Content> GetList(int id)
        {
            return _contentDal.List();
        }

        public List<Content> GetList()
        {
            return _contentDal.List();
        }

        public List<Content> GetListById(int id)
        {
            return _contentDal.List(x=>x.HeadingId==id);
        }
    }
}
