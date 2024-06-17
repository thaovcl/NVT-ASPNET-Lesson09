using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NVTLesson09.Controllers
{
    public class nvtKhoasController : Controller
    {
        private NVT_K22CNT1Lesson09Entities db = new NVT_K22CNT1Lesson07Entities();

        // GET: dthKhoas
        public ActionResult NVTIndex()
        {
            return View(db.nvtKhoa.ToList());
        }

        // GET: dthKhoas/Details/5
        public ActionResult NVTDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvtKhoa dthKhoa = db.dthKhoa.Find(id);
            if (dthKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvtKhoa);
        }

        // GET: dthKhoas/Create
        public ActionResult NVTCreate()
        {
            return View();
        }

        // POST: nvtKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NVTCreate([Bind(Include = "NvtID,NvtTenKh,NvtTrangthai")] nvtKhoa dthKhoa)
        {
            if (ModelState.IsValid)
            {
                db.nvtKhoa.Add(nvtKhoa);
                db.SaveChanges();
                return RedirectToAction("NVTIndex");
            }

            return View(nvtKhoa);
        }

        // GET: dthKhoas/Edit/5
        public ActionResult NVTEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvtKhoa dthKhoa = db.nvtKhoa.Find(id);
            if (nvtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvtKhoa);
        }

        // POST: nvtKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NVTEdit([Bind(Include = "NvtID,NtvTenKh,NvtTrangthai")] nvtKhoa nvtKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvtKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NVTIndex");
            }
            return View(nvtKhoa);
        }

        // GET: nvtKhoas/Delete/5
        public ActionResult DTHDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvtKhoa dthKhoa = db.nvtKhoa.Find(id);
            if (nvtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvtKhoa);
        }

        // POST: dthKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DTHDeleteConfirmed(string id)
        {
            nvtKhoa dthKhoa = db.nvtKhoa.Find(id);
            db.nvtKhoa.Remove(nvtKhoa);
            db.SaveChanges();
            return RedirectToAction("NVTIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}