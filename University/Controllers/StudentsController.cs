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
      return View(_db.Students.ToList());
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Students
        .Include(student=>student.JoinEntities)
        .ThenInclude(join=>join.Lesson)
        .FirstOrDefault(student =>student.StudentId == id);
      return View(thisStudent);
    }
  }
}