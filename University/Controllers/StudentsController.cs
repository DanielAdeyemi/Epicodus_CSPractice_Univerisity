using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using University.Models;

namespace University.Controllers
{
  public class StudentsController : Controller
  {
    private readonly UniversityContext _db;
    public StudentsController(UniversityContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Student> model = _db.Students.ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Students
        .Include(student => student.JoinEntities)
        .ThenInclude(join => join.Lesson)
        .FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }

    public ActionResult Create()
    {
      ViewBag.LessonId = new SelectList(_db.Lessons, "LessonId", "LessonName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      if(ModelState.IsValid)
      {
        _db.Students.Add(student);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(student);
    }
  }
}