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
        public ActionResult Details(int id)
        {
            return View();
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

       
    }
}
