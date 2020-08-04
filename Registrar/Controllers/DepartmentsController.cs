using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Registrar.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly RegistrarContext _db;

    public DepartmentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Department> model = _db.Departments.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisDepartment = _db.Departments
        .Include(department => department.Courses)
        .ThenInclude(join => join.Student)
        .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

//     public ActionResult Edit(int id)
//     {
//       var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
//       return View(thisDepartment);
//     }

//     [HttpPost]
//     public ActionResult Edit(Department department)
//     {
//       _db.Entry(department).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult Delete(int id)
//     {
//       var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
//       return View(thisDepartment);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
//       _db.Courses.Remove(thisCourse);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
  }
}
