using System;
using System.Collections.Generic;
using System.Text;
namespace SMS.Model
{
    public class StudentFee
    {
        
        public System.Int32 StudentId { get; set; }
        public System.Int32 TotalFee { get; set; }
        public System.Int32 RemainingDues { get; set; }
        public System.Int32 Fine { get; set; }
        public System.Int32 TransportDues { get; set; }
        public System.DateTime DueDate { get; set; }
        public System.DateTime LastDate { get; set; }
        public System.Int32 Id { get; set; }
    }
}