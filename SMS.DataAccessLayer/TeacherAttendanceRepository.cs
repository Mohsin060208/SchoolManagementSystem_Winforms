using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;
namespace SMS.DAL
{

    public class TeacherAttendancesService
    {
        private DbClient _dbClient = null;
        public TeacherAttendancesService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetTeacherAttendancesDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from Teacher_Attendance";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public TeacherAttendance GetTeacherAttendance(TeacherAttendance teacherAttendance)
       {
        var query = "SELECT * FROM Teacher_Attendance WHERE Teacher_Id ='" + teacherAttendance.TeacherId + "'";
            
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        teacherAttendance.TeacherId = data.Rows[i].Field<System.Int32>("Teacher_Id");
                           teacherAttendance.TotalAttendance  = data.Rows[i].Field< System.Int32 >("Total_Attendance");
                           teacherAttendance.Presence  = data.Rows[i].Field< System.Int32 >("Presence");
                           teacherAttendance.Absentees  = data.Rows[i].Field< System.Int32 >("Absentees");
                    }
                }
            });
            return teacherAttendance;
       }
    
    public void InsertTeacherAttendance(TeacherAttendance teacherattendance)
    {
       var query = "INSERT INTO Teacher_Attendance(   Teacher_Id ,    Total_Attendance ,    Presence ,    Absentees   )"+
                   "VALUES (  @teacher_id ,    @total_attendance ,    @presence ,    @absentees   );";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@teacher_id",
                    Value = teacherattendance. TeacherId
                },
             new SqlParameter()
                {
                    ParameterName = "@total_attendance",
                    Value = teacherattendance. TotalAttendance
                },
             new SqlParameter()
                {
                    ParameterName = "@presence",
                    Value = teacherattendance. Presence
                },
             new SqlParameter()
                {
                    ParameterName = "@absentees",
                    Value = teacherattendance. Absentees
                }
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    
    public void UpdateTeacherAttendance(TeacherAttendance teacherattendance)
    {
        var query = "UPDATE Teacher_Attendance SET    Total_Attendance  =  @total_attendance  ,      Presence  =  @presence  ,      Absentees  =  @absentees        Where Teacher_Id  =  @teacher_id ";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@teacher_id",
                    Value = teacherattendance. TeacherId
                },
             new SqlParameter()
                {
                    ParameterName = "@total_attendance",
                    Value = teacherattendance. TotalAttendance
                },
             new SqlParameter()
                {
                    ParameterName = "@presence",
                    Value = teacherattendance. Presence
                },
             new SqlParameter()
                {
                    ParameterName = "@absentees",
                    Value = teacherattendance. Absentees
                }
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteTeacherAttendance(int id)
    {
        var query = "Delete From Teacher_Attendance where Id = @id;";
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
