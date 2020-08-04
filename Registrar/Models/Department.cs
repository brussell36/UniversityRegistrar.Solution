using System.Collections.Generic;

namespace Registrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Courses = new HashSet<DepartmentCourseStudent>();
    }

    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public virtual ICollection<DepartmentCourseStudent> Courses { get; set; }
  }
}