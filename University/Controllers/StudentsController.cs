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
    
  }
}