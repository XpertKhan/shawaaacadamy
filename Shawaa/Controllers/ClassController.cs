using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shawaa.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            ClassRepository _Class = new ClassRepository();
            if (Request.IsAjaxRequest())
            {
                return PartialView(_Class.GetAll());
            }
            return View(_Class.GetAll());
        }

        public ActionResult Create()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
    }
}