using System;
using System.Collections.Generic;

namespace StudentLibrary
{
    public partial class Schedules
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int? Grade { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
