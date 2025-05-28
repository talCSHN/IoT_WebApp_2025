using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp01.Controllers
{
    public class BoardController : Controller
    {
        // GET: BoardController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BoardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BoardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoardController/Create
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

        // GET: BoardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BoardController/Edit/5
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

        // GET: BoardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BoardController/Delete/5
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
