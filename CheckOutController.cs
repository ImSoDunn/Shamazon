using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shamazon
{
    public class CheckOutController : Controller
    {
        // GET: CheckOutController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CheckOutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CheckOutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckOutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckOutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckOutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckOutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckOutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
