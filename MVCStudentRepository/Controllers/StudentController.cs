using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStudentRepository.Models.Repositories;

namespace MVCStudentRepository.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository repository = null;

        public StudentController()
        {
            this.repository = new StudentRepository();
        }

        public StudentController(IStudentRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Student> model = (List<Student>)repository.SelectAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            Student existing = repository.SelectByID(id);
            return View(existing);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                repository.Insert(obj);
                repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        [HttpGet, ActionName("Edit")]
        public ActionResult ConfirmEdit(string id)
        {
            Student existing = repository.SelectByID(id);
            return View(existing);
        }

        [HttpPost]
        public ActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                repository.Update(obj);
                repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        [HttpGet, ActionName("Delete")]
        public ActionResult ConfirmDelete(string id)
        {
            Student existing = repository.SelectByID(id);
            return View(existing);
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            repository.Delete(id);
            repository.Save();
            return RedirectToAction("Index");
        }
    }


}