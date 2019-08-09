using System;
using System.Collections.Generic;

namespace StudentLibrary
{
    public partial class Majors
    {
        public Majors()
        {
            Courses = new HashSet<Courses>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSat { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
