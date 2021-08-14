using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        // Allows app to specify primary key rather than having the database generate it
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID {get;set;}
        public string Title {get;set;}
        public int Credits {get;set;}

        // Creates a hashset (by default)
        public ICollection<Enrollment> Enrollments {get;set;}
    }
}
