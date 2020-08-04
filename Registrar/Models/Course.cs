using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.Students = new HashSet<DepartmentCourseStudent>();
    }

    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public virtual ICollection<DepartmentCourseStudent> Students { get; set; }
  }
}