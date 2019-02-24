using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;
namespace SMS.DAL
{

    public class StudentAttendancesService
    {
        private DbClient _dbClient = null;
        public StudentAttendancesService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetStudentAttendancesDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from Student_Attendance";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public StudentAttendance GetStudentAttendance(StudentAttendance studentAttendance)
       {
        var query = "SELECT * FROM Student_Attendance";
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                           studentAttendance.StudentId  = data.Rows[0].Field< System.Int32 >("Student_Id");
                           studentAttendance.TotalAttendance  = data.Rows[0].Field< System.Int32 >("Total_Attendance");
                           studentAttendance.Presence  = data.Rows[0].Field< System.Int32 >("Presence");
                           studentAttendance.Absentees  = data.Rows[0].Field< System.Int32 >("Absentees");
                }
            });
            return studentAttendance;
       
       }
    
    public void InsertStudentAttendance(StudentAttendance studentattendance)
    {
       var query = "INSERT INTO Student_Attendance(   Student_Id ,    Total_Attendance ,    Presence ,    Absentees )"+
                   "VALUES (  @student_id ,    @total_attendance ,    @presence ,    @absentees   );";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@student_id",
                    Value = studentattendance. StudentId
                },
             new SqlParameter()
                {
                    ParameterName = "@total_attendance",
                    Value = studentattendance. TotalAttendance
                },
             new SqlParameter()
                {
                    ParameterName = "@presence",
                    Value = studentattendance. Presence
                },
             new SqlParameter()
                {
                    ParameterName = "@absentees",
                    Value = studentattendance. Absentees
                },
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    
    public void UpdateStudentAttendance(StudentAttendance studentattendance)
    {
       var query = "UPDATE Student_Attendance SET    Student_Id  =  @student_id  ,      Total_Attendance  =  @total_attendance  ,      Presence  =  @presence  ,      Absentees  =  @absentees  ,      Where Id = @id;";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@student_id",
                    Value = studentattendance. StudentId
                },
             new SqlParameter()
                {
                    ParameterName = "@total_attendance",
                    Value = studentattendance. TotalAttendance
                },
             new SqlParameter()
                {
                    ParameterName = "@presence",
                    Value = studentattendance. Presence
                },
             new SqlParameter()
                {
                    ParameterName = "@absentees",
                    Value = studentattendance. Absentees
                },
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteStudentAttendance(int id)
    {
        var query = "Delete From Student_Attendance where Id = @id;";
        List<SqlParameter> parameter = new List<SqlParameter>
        {
            new SqlParameter()
            {
                ParameterName = "@id",
                Value = id
            }
        };
        _dbClient.InvokeParameters(query, parameter);
    }
  }
}
