using Microsoft.AspNetCore.Mvc;
using MyMVC_CRUD.DataContext;
using MyMVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC_CRUD.Controllers
{
    public class UserController : Controller

    {
        private readonly CrudDBContext _cruddbcontext;

        public UserController(CrudDBContext crudDBContext)
        {
            _cruddbcontext = crudDBContext;
        }
      
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Register (User u)
        {
            if(ModelState.IsValid)
            {
                _cruddbcontext.Users.Add(u);
                _cruddbcontext.SaveChanges();
                return RedirectToAction("Allusers");
            }
            return View("Index");
        }

        public IActionResult Allusers()
        {
            return View(_cruddbcontext.Users.ToList());
        }
        [HttpGet]

        public IActionResult Edit (int id)
        {
            return View(_cruddbcontext.Users.ToList());
        }

        public IActionResult Delete(int id)
        {
            return View();
        }


    }
}
