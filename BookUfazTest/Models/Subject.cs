using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUfazTest.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public double Coefficient { get; set; }
        public int Semester { get; set; }
        public int Midterm { get; set; }
        //1-First Midterm; 2-Second Midterm; 3-Final
        public int YearId { get; set; }
        public int FacultyId { get; set; }



        public Faculty Faculty { get; set; }
        public Year Year { get; set; }

    }
}
