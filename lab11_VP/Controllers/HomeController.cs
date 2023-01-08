using lab11_VP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab11_VP.Controllers
{
    public class HomeController : Controller
    {
        List<Student> std = new List<Student>()
        {
            new Student (){id=1,full_name="Fatima Afzaal",contact="12345678",address="Attock",gender="Female",cgpa=3.95},
            new Student (){id=2,full_name="Muhammad Afzaal",contact="12346987",address="Attock",gender="Male",cgpa=4.0},
            new Student (){id=3,full_name="Hajra Komal",contact="12345678",address="Attock",gender="Female",cgpa=3.5},
            new Student (){id=4,full_name="Muhammad Ahmed",contact="1200008",address="Kamra",gender="Male",cgpa=3.0},
            new Student (){id=5,full_name="Muhammad Dawood",contact="64348",address="Attock",gender="Male",cgpa=3.2},
            new Student (){id=6,full_name="Ayesha Afzaal",contact="12345678",address="Islamabad",gender="Female",cgpa=2.95},
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(std);
        }
        public ActionResult Edit(int ids)
        {
            Student stud = new Student();
            stud = std.FirstOrDefault(x => x.id == ids);
            return View(stud);
        }
        public ActionResult Details(int id)
        {
            Student stud = new Student();
            stud = std.FirstOrDefault(x => x.id == id);
            return View(stud);
        }
        public ActionResult Delete(int ids)
        {
            Student stud = new Student();
            stud = std.FirstOrDefault(x => x.id == ids);
            return View(stud);
        }
        public ActionResult create()
        {
            //Student stud = new Student();
           // stud = std.FirstOrDefault(x => x.id == ids);
            return View();
        }

    }
}