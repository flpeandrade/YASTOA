using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YastoaRecode.Controllers
{
    public class ProdutoExibController : Controller
    {
        // GET: ProdutoExibController
        public ActionResult PrimeiroProduto()
        {
            return View();
        }

        // GET: ProdutoExibController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdutoExibController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoExibController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(PrimeiroProduto));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoExibController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutoExibController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(PrimeiroProduto));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoExibController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutoExibController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(PrimeiroProduto));
            }
            catch
            {
                return View();
            }
        }
    }
}
