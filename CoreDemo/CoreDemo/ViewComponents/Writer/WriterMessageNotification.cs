using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int p = 2;
            var values = message2Manager.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
