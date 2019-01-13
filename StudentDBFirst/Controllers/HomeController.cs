using StudentDBFirst.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDBFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Student> students;

            using (JIStudentDBEntities db = new JIStudentDBEntities())
            {
                students = db.Students.ToList<Student>();
            }

            return View(students);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult New(Student student)
        {
            if (ModelState.IsValid)
            {
                using (JIStudentDBEntities db = new JIStudentDBEntities())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }

                return RedirectToAction("Index", "Home");
            }

            return View(student);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != 0)
            {
                using (JIStudentDBEntities db = new JIStudentDBEntities())
                {
                    Student student = db.Students.Where(x => x.StudentId == id).FirstOrDefault<Student>();

                    return View(student);
                }
            }

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                using (JIStudentDBEntities db = new JIStudentDBEntities())
                {
                   db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                }

                return RedirectToAction("Index", "Home");
            }

            return View(student);
        }
    }
}