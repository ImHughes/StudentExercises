using System;
using StudentExercises.Models;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var csExercise = new Exercise()
            {
                Name = "C# Exercise",
                Language = "C#"
            };

            var jsExercise = new Exercise()
            {
                Name = "JavaScript Exercise",
                Language = "JavaScript"
            };

            var phExercise = new Exercise()
            {
                Name = "Python Exercise",
                Language = "Python"
            };

            var sqlExercise = new Exercise()
            {
                Name = "SQL Exercise",
                Language = "SQL"
            };

            var c30 = new Cohort()
            {
                Name = "Day Cohort 30"
            };
            var c31 = new Cohort()
            {
                Name = "Day Cohort 31"
            };
            var c32 = new Cohort()
            {
                Name = "Day Cohort 32"
            };
            var c33 = new Cohort()
            {
                Name = "Day Cohort 33"
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

            jisie.AssignExercise(logan, csExercise);
            jisie.AssignExercise(logan, jsExercise);
            adam.AssignExercise(dek, csExercise);
            adam.AssignExercise(dek, jsExercise);
            brian.AssignExercise(jake, csExercise);
            brian.AssignExercise(jake, jsExercise);
        }
    }
}
