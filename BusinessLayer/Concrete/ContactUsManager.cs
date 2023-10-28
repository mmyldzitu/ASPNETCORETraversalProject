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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs t)
        {
            _contactUsDal.Insert(t);
        }

        public void TContactUsStatustoFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> TGetListWhichFalse()
        {
            return _contactUsDal.GetListWhichFalse();
        }

        public List<ContactUs> TGetListWhichTrue()
        {
            return _contactUsDal.GetListWhichTrue();
        }

        public void TUpdate(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
