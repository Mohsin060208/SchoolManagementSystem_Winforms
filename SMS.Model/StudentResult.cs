using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Model
{
    public class StudentResult
    {
        public System.Int32 Id { get; set; }
        public System.Int32 StudentId { get; set; }
        public System.Int32 TotalMarks { get; set; }
        public System.Int32 ObtainedMarks { get; set; }
        public System.String Percentage { get; set; }
    }
}
