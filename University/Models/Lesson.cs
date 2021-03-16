using System.Collections.Generic;

namespace University.Models
{
  public class Lesson
  {
    public Lesson()
    {
      this.JoinEntities = new HashSet<StudentLesson>();
    }

    public int LessonId { get; set; }
    [Required]
    public string LessonName { get; set; }
    public string LessonNumber { get; set; }

    public virtual ICollection<CategoryItem> JoinEntities { get; set; }
  }
}