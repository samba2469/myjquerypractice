﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace myjquerypractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        sivaEntities _modaldata = null;
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Display_userdetails(register _reguserdata)
        {
            _modaldata = new sivaEntities();
            var data = _modaldata.Diplay_All().ToList();
           
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public PartialViewResult Create()   //Insert PartialView  
        {
            return PartialView("Create");
        }
         
        [HttpPost]
        public ActionResult indert_data(register _reguserdata)
        {
            _modaldata = new sivaEntities();
            _modaldata.register_Insert(_reguserdata.id,_reguserdata.name,_reguserdata.password,_reguserdata.email,_reguserdata.phno,_reguserdata.dateofbirth,_reguserdata.gender,_reguserdata.language,_reguserdata.address);
            _modaldata.SaveChanges();
            return View();
        }
        public PartialViewResult Add()   //Insert PartialView  
        {
            return PartialView();
        }
        public ActionResult Addregdata()   //Insert PartialView  
        {

            return View();
        }

    }
}