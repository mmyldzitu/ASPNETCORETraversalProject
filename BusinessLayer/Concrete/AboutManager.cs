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
    public class AboutManager : IAboutService
    {
        IAboutDal _abautDal;

        public AboutManager(IAboutDal abautDal)
        {
            _abautDal = abautDal;
        }

        public void TAdd(About t)
        {
            _abautDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _abautDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
           return _abautDal.GetList();
        }

        public void TUpdate(About t)
        {
            _abautDal.Update(t);
        }
    }
}
