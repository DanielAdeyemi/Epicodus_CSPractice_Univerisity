using System.Collections.Generic;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<StudentLesson>();
    }

    public int StudentId { get; set; }
    [Required]
    public string Name { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime Enroll { get; set; }

    public virtual ICollection<StudentLesson> JoinEntities { get; }

  }
}