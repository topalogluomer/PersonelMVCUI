using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelMVCUI.Models.EntityFramework;

namespace PersonelMVCUI.Controllers
{
    public class PersonelController : Controller
    {
        PersonelDbEntities db = new PersonelDbEntities();

        public ActionResult Index()
        {
            var model = db.Personel.ToList();

            return View(model);
        }
    }
}