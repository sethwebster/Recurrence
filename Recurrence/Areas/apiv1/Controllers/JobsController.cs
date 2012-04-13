using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recurrence.Models;

namespace Recurrence.Areas.apiv1.Controllers
{ 
    public class JobsController : Controller
    {
        private IDataRepository db = null;

        public JobsController(IDataRepository repository)
        {
            this.db = repository;
        }

        //
        // GET: /apiv1/Jobs/

        public ViewResult Index()
        {
            return View(db.Jobs.ToList());
        }

        //
        // GET: /apiv1/Jobs/Details/5

        public ViewResult Details(int id)
        {
            Job job = db.Jobs.Find(id);
            return View(job);
        }

        //
        // GET: /apiv1/Jobs/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /apiv1/Jobs/Create

        [HttpPost]
        public ActionResult Create(Job job)
        {
            if (ModelState.IsValid)
            {
                db.Jobs.Add(job);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(job);
        }
        
        //
        // GET: /apiv1/Jobs/Edit/5
 
        public ActionResult Edit(int id)
        {
            Job job = db.Jobs.Find(id);
            return View(job);
        }

        //
        // POST: /apiv1/Jobs/Edit/5

        [HttpPost]
        public ActionResult Edit(Job job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(job);
        }

        //
        // GET: /apiv1/Jobs/Delete/5
 
        public ActionResult Delete(int id)
        {
            Job job = db.Jobs.Find(id);
            return View(job);
        }

        //
        // POST: /apiv1/Jobs/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Job job = db.Jobs.Find(id);
            db.Jobs.Remove(job);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}