using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Models
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

        public List<Exercise> Exercises { get; set; } = new List<Exercise>();


    }
}
