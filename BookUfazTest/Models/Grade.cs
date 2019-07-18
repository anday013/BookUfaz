using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUfazTest.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int? StudentUserId { get; set; }
        public int SubjectId { get; set; }
        public double Mark { get; set; }
        public StudentUser StudentUser{ get; set; }
        public Subject Subject { get; set; }
        
        




    }
}
