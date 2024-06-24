using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAplication.Controllers
{
    public class CommitController : Controller
    {
        // GET: CommitController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CommitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CommitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommitController/Create
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

        // GET: CommitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommitController/Edit/5
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

        // GET: CommitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommitController/Delete/5
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
