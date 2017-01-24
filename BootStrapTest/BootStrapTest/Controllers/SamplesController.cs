using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootStrapTest.Models;

namespace BootStrapTest.Controllers
{
    public class SamplesController : Controller
    {
		//private SampleContext db = new SampleContext();

        //
        // GET: /Samples/

        public ActionResult Index()
        {
			var samples = this.GetSampleViewList();

			return View(samples);
        }

        //
        // GET: /Samples/Details/5

        public ActionResult Details(int id = 0)
        {
			//Sample sample = db.Samples.Find(id);
			//if (sample == null)
			//{
			//	return HttpNotFound();
			//}

			var sample = new SampleViewModel("aaaaa", new DateTime(2016, 1, 2), "1", "1", false);

            return View(sample);
        }

        //
        // GET: /Samples/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Samples/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SampleViewModel sample)
        {
			//if (ModelState.IsValid)
			//{
			//	db.Samples.Add(sample);
			//	db.SaveChanges();
			//	return RedirectToAction("Index");
			//}

            return View(sample);
        }

        //
        // GET: /Samples/Edit/5

        public ActionResult Edit(int id = 0)
        {
			//Sample sample = db.Samples.Find(id);
			//if (sample == null)
			//{
			//	return HttpNotFound();
			//}

			var sample = new SampleViewModel("aaaaa", new DateTime(2016, 1, 2), "1", "1", false);

            return View(sample);
        }

        //
        // POST: /Samples/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SampleViewModel sample)
        {
			//if (ModelState.IsValid)
			//{
			//	db.Entry(sample).State = EntityState.Modified;
			//	db.SaveChanges();
			//	return RedirectToAction("Index");
			//}
            return View(sample);
        }

        //
        // GET: /Samples/Delete/5

        public ActionResult Delete(int id = 0)
        {
			//Sample sample = db.Samples.Find(id);
			//if (sample == null)
			//{
			//	return HttpNotFound();
			//}

			var sample = new SampleViewModel("aaaaa", new DateTime(2016, 1, 2), "1", "1", false);

            return View(sample);
        }

        //
        // POST: /Samples/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			//Sample sample = db.Samples.Find(id);
			//db.Samples.Remove(sample);
			//db.SaveChanges();
			return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
			//db.Dispose();
            base.Dispose(disposing);
        }


		private List<SampleViewModel> GetSampleViewList()
		{
			var samples = new List<SampleViewModel>();

			samples.Add(new SampleViewModel("aaaaa", new DateTime(2016, 1, 2), "1", "1", false));
			samples.Add(new SampleViewModel("bbbbb", new DateTime(2016, 1, 2), "1", "1", false));
			samples.Add(new SampleViewModel("ccccc", new DateTime(2016, 1, 2), "1", "1", false));
			samples.Add(new SampleViewModel("ddddd", new DateTime(2016, 1, 2), "1", "1", false));
			samples.Add(new SampleViewModel("eeeee", new DateTime(2016, 1, 2), "1", "1", false));

			return samples;
		}
    }
}