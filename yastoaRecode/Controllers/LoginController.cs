using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yastoaRecode.Models.Login;

namespace yastoaRecode.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginContext _Context;
        public LoginController(LoginContext context)
        {
            _Context = context;
        }

        // GET: LoginController
        public ActionResult Login()
        {
            return View();
        }

        // GET: LoginController/Details/5
        public IActionResult Perfil()
        {
            var perfil = _Context.Logins.ToList();
            return View(perfil);
        }

        // GET: LoginController/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        public ActionResult Cadastrar(Login login)
        {
            if(_Context == null)
            {
                return NotFound("Cadastro");
            }

            _Context.Add(login);
            _Context.SaveChanges();

            return RedirectToAction("Login");
        }

        public IActionResult EditConta(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var login = _Context.Logins.SingleOrDefault(a => a.ID == id);

            if (login == null)
            {
                return NotFound();
            }
            return View(login);
        }
        [HttpPost]
        public IActionResult EditConta(int id, Login login)
        {
            if (id != login.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _Context.Update(login);
                _Context.SaveChanges();

                return RedirectToAction("Login");
            }
            return View(login);
        }
        public IActionResult DeleteConta(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var conta = _Context.Logins.SingleOrDefault(a => a.ID == id);

            if (conta == null)
            {
                return NotFound();
            }
            return View(conta);
        }
        [HttpPost, ActionName("DeleteConta")]
        public IActionResult Delet(int id)
        {
            var conta = _Context.Logins.SingleOrDefault(a => a.ID == id);
            if (conta == null)
            {
                return NotFound();
            }
            _Context.Logins.Remove(conta);
            _Context.SaveChanges();
            return RedirectToAction("Login");
        }
        public IActionResult DetailsPerfil(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Det = _Context.Logins.SingleOrDefault(a => a.ID == id);
            if (Det == null)
            {
                return NotFound();
            }
            return View(Det);
        }

    }
}
