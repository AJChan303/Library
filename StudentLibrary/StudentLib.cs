using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary {
    public class StudentLib {

        public static string About = "About StudentLib";
        public List<Student> ListStudents() {
            var db = new AppEfDbContext();
            return db.Students.ToList();


        }
        public Student GetStudent(int id) {
            var db = new AppEfDbContext();
  
            return (db.Students.Find(id) == null) ?null : db.Students.Find(id);
        }
        public bool InsertStudent(Student student) {
            
            var db = new AppEfDbContext();
            student.Id = 0;
            if (student.MajorId != null)
            {
                var major = db.Majors.Find(student.MajorId);
                if (major == null)
                {
                    return false;
                }
            }
            db.Students.Add(student);
            db.SaveChanges();
            return true;
        }
        public bool UpdateStudent(Student s) {
            
            
            var sDB = GetStudent(s.Id);
            if(sDB == null) {
                throw new Exception("Student not found");
            }
            var db = new AppEfDbContext();
            sDB.Firstname = s.Firstname;
            sDB.Lastname = s.Lastname;
            sDB.Gpa = s.Gpa;
            sDB.Sat = s.Sat;
            sDB.IsFulltime = s.IsFulltime;
            sDB.MajorId = s.MajorId;
            var mid = db.Majors.Find(s.Major.Id);
            if (mid == null) {
                return false;

            }
            else {
                db.Students.Update(sDB);
                db.SaveChanges();
                return true;
            }

        }
        public bool DeleteStudent(Student student) {
            var del = GetStudent(student.Id);
            var db = new AppEfDbContext();
            if(del == null) {
                return false;
            }
            db.Students.Remove(del);
            db.SaveChanges();
            return true;
        }
        public bool DeleteStudentById(int id) {

            var del = GetStudent(id);
            if (del == null)
            {
                return false;
            }
            var db = new AppEfDbContext();
            db.Students.Remove(del);
            db.SaveChanges();
            return true;
        }
    }
}