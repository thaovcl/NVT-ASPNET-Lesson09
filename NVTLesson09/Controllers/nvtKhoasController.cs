using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NVTLesson09.Models;

namespace NVTLesson09.Controllers
{
    public class NvtKhoasController : Controller
    {
        private NVT_K22CNT1Lesson07Entities1 db = new NVT_K22CNT1Lesson07Entities1();

        // GET: NvtKhoas
        public ActionResult Index()
        {
            return View(db.nvtKhoas.ToList());
        }

        // GET: NvtKhoas/Details/5
        public ActionResult NvtDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvtKhoa nvtKhoa = db.nvtKhoas.Find(id);
            if (nvtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvtKhoa);
        }

        // GET: NvtKhoas/Create
        public ActionResult NvtCreate()
        {
            return View();
        }

        // POST: NvtKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvtCreate([Bind(Include = "NvtID,NvtTenKh,NvtTrangthai")] nvtKhoa nvtKhoa)
        {
            if (ModelState.IsValid)
            {
                db.nvtKhoas.Add(nvtKhoa);
                db.SaveChanges();
                return RedirectToAction("NvtIndex");
            }

            return View(nvtKhoa);
        }

        // GET: NvtKhoas/Edit/5
        public ActionResult NvtEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvtKhoa nvtKhoa = db.nvtKhoas.Find(id);
            if (nvtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvtKhoa);
        }

        // POST: NvtKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvtEdit([Bind(Include = "NvtID,NvtTenKh,NvtTrangthai")] nvtKhoa nvtKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvtKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NvtIndex");
            }
            return View(nvtKhoa);
        }

        // GET: NvtKhoas/Delete/5
        public ActionResult NvtDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvtKhoa nvtKhoa = db.nvtKhoas.Find(id);
            if (nvtKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvtKhoa);
        }

        // POST: NvtKhoas/Delete/5
        [HttpPost, ActionName("NvtDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NvtDeleteConfirmed(string id)
        {
            nvtKhoa nvtKhoa = db.nvtKhoas.Find(id);
            db.nvtKhoas.Remove(nvtKhoa);
            db.SaveChanges();
            return RedirectToAction("NvtIndex");
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
