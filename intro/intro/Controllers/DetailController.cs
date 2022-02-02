using intro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Index), "Home");
        }

        public IActionResult Detail(int? id)
        {
            var students = new List<Student>
            {
                new Student{Id = 1, Name = "Elnur", Surname = "Maharramli", Age = 28},
                new Student{Id = 2, Name = "Orxan", Surname = "Nasibli", Age = 29},
                new Student{Id = 3, Name = "Sabir", Surname = "Amirli", Age = 25},
            };

            if (id == null)
            {
                return NotFound();
            }

            var student = students.Find(student => student.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        public IActionResult InfoByName(string name)
        {
            var students = new List<Student>
            {
                new Student{ Name = "Elnur", Surname = "Maharramli", Age = 28},
                new Student{ Name = "Orxan", Surname = "Nasibli", Age = 21},
                new Student{ Name = "Sabir", Surname = "Amirli", Age = 25}
            };

            if (name == null)
            {
                return NotFound();
            }

            var student = students.FindAll(current => current.Name == name);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        public IActionResult All()
        {
            var students = new List<Student>
            {
                new Student{Id = 1, Name = "Elnur", Surname = "Maharramli", Age = 28},
                new Student{Id = 2, Name = "Orxan", Surname = "Nasibli", Age = 29},
                new Student{Id = 3, Name = "Sabir", Surname = "Amirli", Age = 25},
            };

            

            return Json(students);
        }
    }
}