using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Models
{
     class Cohort
    {
        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public List<Instructor> Instructors { get; set; }


        public void addInstructorToCohort(Instructor instructor)
        {
            instructor.Cohort = Name;

            Instructors.Add(instructor);
        }

        public void addStudentToCohort(Student student)
        {
            student.Cohort = Name;

            Students.Add(student);
        }
    

        
    }
}
