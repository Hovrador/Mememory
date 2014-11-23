using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mememory.Controllers
{
    public class MememoryController : Controller
    {
        // GET: Mememory
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mememory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mememory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mememory/Create
        [HttpPost]
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

        // GET: Mememory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mememory/Edit/5
        [HttpPost]
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

        // GET: Mememory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mememory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
