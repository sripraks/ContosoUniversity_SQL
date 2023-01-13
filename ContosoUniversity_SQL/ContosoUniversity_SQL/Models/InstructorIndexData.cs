﻿using ContosoUniversity.Models;

namespace ContosoUniversity_SQL.Models
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor>? Instructors { get; set; }
        public IEnumerable<Course>? Courses { get; set; }
        public IEnumerable<Enrollment>? Enrollments { get; set; }
    }
}
