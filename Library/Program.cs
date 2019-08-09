using System;
using StudentLibrary;
using GregsUtilitiesLibrary;


namespace Library {
    class Program {
        static void Main(string[] args) {
            var lib = new StudentLib();

            var pat = new Student();
               
                pat.Firstname = "Patrick";
                pat.Lastname = "Star";
                pat.Gpa = 1.4;
                pat.Sat = 900;
                pat.IsFulltime = true;
                pat.MajorId = 3;

            lib.InsertStudent(pat);


           // var del = lib.GetStudent(7);
           //lib.DeleteStudent(del);

            //update Alex id 1 
            var al = lib.GetStudent(1);
            if (al == null) {
                throw new Exception("Student not found");

            }
            al.Firstname = "Alexzncdf";
            var success = lib.UpdateStudent(al);
            System.Console.WriteLine(success);
            var students = lib.ListStudents();
            foreach (var stud in students) {
                System.Console.WriteLine($"{stud.Firstname} {stud.Lastname} {stud.Major.Description}");
            }
            var st = new StudentLib();
            var stu = st.GetStudent(50);
            if (stu == null) {
                System.Console.WriteLine("Student not found");

            }
            else {
                System.Console.WriteLine(stu.Firstname);
            }
        }

    }
}
