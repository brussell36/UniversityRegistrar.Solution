using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public bool Completed { get; set; } = false;
    public ICollection<CourseStudent> Courses { get; }
  }
}