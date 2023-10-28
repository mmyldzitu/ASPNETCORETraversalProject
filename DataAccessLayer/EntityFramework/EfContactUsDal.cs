using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
      
        public void ContactUsStatustoFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListWhichFalse()
        {
            using (var c = new Context())
            {
                var values = c.ContactUses.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListWhichTrue()
        {
            using(var c = new Context())
            {
                var values = c.ContactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }
    }
}
