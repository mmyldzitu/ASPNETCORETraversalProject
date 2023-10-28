using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService:IGenericServise<ContactUs>
    {
        List<ContactUs> TGetListWhichTrue();
        List<ContactUs> TGetListWhichFalse();

        void TContactUsStatustoFalse(int id);
    }
}
