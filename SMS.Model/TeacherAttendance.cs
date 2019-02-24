using System;
using System.Collections.Generic;
using System.Text;
namespace SMS.Model
{
    public class TeacherAttendance
    {
        
        public System.Int32 TeacherId { get; set; }
        public System.Int32 TotalAttendance { get; set; }
        public System.Int32 Presence { get; set; }
        public System.Int32 Absentees { get; set; }
        public System.Int32 Id { get; set; }
    }
}