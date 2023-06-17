using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRectt
{
    public class QualificationDetails
    {
        public int Id { get; set; }
        public string RegistrationId { get; set; }
        public string Qualification { get; set; }
        public double PercentageOfMarks { get; set; }
        public string Discipline { get; set; }
        public string Division { get; set; }
        public string CGPA { get; set; }
        public DateTime DurationOfCourseFrom { get; set; }
        public DateTime To { get; set; }
        public DateTime DateOfResult { get; set; }
        public string ModeOfCourse { get; set; }
        public string University { get; set; }
        public string Institution { get; set; }
       
       
        

    }
}
