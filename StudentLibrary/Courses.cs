using System;
using System.Collections.Generic;

namespace StudentLibrary
{
    public partial class Courses
    {
        public Courses()
        {
            Schedules = new HashSet<Schedules>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int Credits { get; set; }
        public int? MajorId { get; set; }

        public virtual Majors Major { get; set; }
        public virtual ICollection<Schedules> Schedules { get; set; }
    }
}
