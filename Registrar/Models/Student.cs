using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<DepartmentCourseStudent>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public bool Completed { get; set; } = false;
    public ICollection<DepartmentCourseStudent> Courses { get; }
  }
}