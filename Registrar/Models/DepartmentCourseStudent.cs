namespace Registrar.Models
{
  public class CourseStudent
  {
    public int DepartmentCourseStudentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public int DepartmentId { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
    public Department Department { get; set; }
  }
}