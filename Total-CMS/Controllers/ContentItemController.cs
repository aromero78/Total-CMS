﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Total_CMS.Controllers
{
    public class ContentItemController : Controller
    {
        //
        // GET: /Content/

        public ActionResult Index(int FolderId)
        {
            return View();
        }

        //
        // GET: /Content/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Content/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Content/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Content/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Content/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
