using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)

        {
            var studentExercise = new Exercise()
            {
                Name = "Student Exercise",
                Language = "C#"
            };

            var jsExercise = new Exercise()
            {
                Name = "Chicken Monkey",
                Language = "JavaScript"
            };

            var journal = new Exercise()
            {
                Name = "Journal",
                Language = "HTML"
            };

            var sqlExercise = new Exercise()
            {
                Name = "Data",
                Language = "SQL"
            };

            var c30 = new Cohort()
            {
                CohortName = "Day Cohort 30"
            };
            var c31 = new Cohort()
            {
                CohortName = "Day Cohort 31"
            };
            var c32 = new Cohort()
            {
                CohortName = "Day Cohort 32"
            };
            var c33 = new Cohort()
            {
                CohortName = "Day Cohort 33"
            };

            var adam = new Instructor
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "Teachers Pet",
                Specialty = "Hacking"

            };
            var brian = new Instructor
            {
                FirstName = "Brian",
                LastName = "Highfive",
                SlackHandle = "Rocker",
                Specialty = "High Five"

            };
            var jisie = new Instructor
            {
                FirstName = "Jisie",
                LastName = "David",
                SlackHandle = "Bigboss",
                Specialty = "Hacking"

            };
            var bill = new Instructor
            {
                FirstName = "Bill",
                LastName = "Bob",
                SlackHandle = "Red neck",
                Specialty = "Shooting guns"

            };

            c32.addInstructorToCohort(brian);
            c32.addInstructorToCohort(bill);
            c32.addInstructorToCohort(jisie);

            var jake = new Student
            {
                FirstName = "Jake",
                LastName = "Smith",
                SlackHandle = "JSmith"
            };

            var logan = new Student
            {
                FirstName = "Logan",
                LastName = "Baxter",
                SlackHandle = "Baxter"

            };

            var dek = new Student
            {
                FirstName = "Dek",
                LastName = "America",
                SlackHandle = "DekYea"
            };

            c32.addStudentToCohort(dek);
            c32.addStudentToCohort(logan);
            c32.addStudentToCohort(jake);

            jisie.AssignExercise(logan, studentExercise);
            jisie.AssignExercise(logan, jsExercise);
            adam.AssignExercise(dek, studentExercise);
            adam.AssignExercise(dek, jsExercise);
            brian.AssignExercise(jake, studentExercise);
            brian.AssignExercise(jake, jsExercise);

            var AllStudents = new List <Student>();
            {
                AllStudents.Add(logan);
                AllStudents.Add(dek);
                AllStudents.Add(jake);                  
            };

            var AllInstructors = new List<Instructor>();
            {
                AllInstructors.Add(adam);
                AllInstructors.Add(brian);
                AllInstructors.Add(jisie);
            };

            var AllExercises = new List<Exercise>();
            {
                AllExercises.Add(jsExercise);
                AllExercises.Add(journal);
                AllExercises.Add(studentExercise);
                AllExercises.Add(sqlExercise);
            };

            var AllCohorts = new List<Cohort>();
            {
                AllCohorts.Add(c30);
                AllCohorts.Add(c31);
                AllCohorts.Add(c32);
                AllCohorts.Add(c33);
            };

            List<Exercise> JSExercise = (from exercise in AllExercises
                                         where exercise.Language == "JavaScript"
                                         select exercise).ToList();
            foreach (Exercise exer in JSExercise)
            {
                Console.WriteLine($"List of JS exercises: {exer.Name}");
            }

            List<Student> studentsInChorty = ( from Student in AllStudents
                                               where Student.cohort)
        }
    }
}
