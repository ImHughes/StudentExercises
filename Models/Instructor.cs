using System;
using System.Collections.Generic;


namespace StudentExercises
{
    class Instructor : NSSPerson
    {
        internal string _cohort;

        public string Specialty { get; set; }
        public object FirstName { get; internal set; }
        public object LastName { get; internal set; }

        public Instructor(string firstname, string lastname, string slackhandle, string specialty, string cohort)
        {
            _cohort = cohort;
            FirstName = firstname;
            LastName = lastname;
            SlackHandle = slackhandle;
            Specialty = specialty;
        }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.ExerciseList.Add(exercise);
        }
    }
}
