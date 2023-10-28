using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context c = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = c.Comments.Where(x => x.DestinationID == id).Count();
            var values = commentManager.GetListCommentWithDestinationAndAppUser(id);
            return View(values);
        }
    }
}
