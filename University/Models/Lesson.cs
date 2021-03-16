using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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

    public virtual ICollection<StudentLesson> JoinEntities { get; set; }
  }
}