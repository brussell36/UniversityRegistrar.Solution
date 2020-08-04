using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.StudentsDepartments = new HashSet<DepartmentCourseStudent>();
    }

    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public virtual ICollection<DepartmentCourseStudent> StudentsDepartments { get; set; }
  }
}