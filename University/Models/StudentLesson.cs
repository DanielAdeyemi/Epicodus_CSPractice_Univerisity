namespace University.Models
{
  public class StudentLesson
  {
    public int StudentLessonId { get; set; }
    public int StudentId { get; set; }
    public int LessonId { get; set; }
    public virtual Student Student { get; set; }
    public virtual Lesson Lesson { get; set; }
  }
}