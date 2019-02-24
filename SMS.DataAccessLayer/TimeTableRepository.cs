using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;
namespace SMS.DAL
{

    public class TimeTablesService
    {
        private DbClient _dbClient = null;
        public TimeTablesService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetTimeTablesDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from Time_Table";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public TimeTable GetTimeTable(TimeTable timeTable)
       {
        var query = "SELECT * FROM Time_Table WHERE Teacher_Id ='" + timeTable.TeacherId + "'";
            
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                          timeTable.Monday = data.Rows[i].Field<System.String>("Monday");
                          timeTable.Tuesday = data.Rows[i].Field<System.String>("Tuesday");
                          timeTable.Wednesday = data.Rows[i].Field<System.String>("Wednesday");
                          timeTable.Thursday = data.Rows[i].Field<System.String>("Thursday");
                          timeTable.Friday = data.Rows[i].Field<System.String>("Friday");
                          timeTable.Saturday = data.Rows[i].Field<System.String>("Saturday");
                    }
                }
            });
            return timeTable;
       }
    public void InsertTimeTable(TimeTable timetable)
    {
       var query = "INSERT INTO Time_Table(   Teacher_Id ,    Monday ,    Tuesday ,    Wednesday ,    Thursday ,    Friday ,    Saturday )"+
                   "VALUES (  @teacher_id ,    @monday ,    @tuesday ,    @wednesday ,    @thursday ,    @friday ,    @saturday );";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@teacher_id",
                    Value = timetable. TeacherId
                },
             new SqlParameter()
                {
                    ParameterName = "@monday",
                    Value = timetable. Monday
                },
             new SqlParameter()
                {
                    ParameterName = "@tuesday",
                    Value = timetable. Tuesday
                },
             new SqlParameter()
                {
                    ParameterName = "@wednesday",
                    Value = timetable. Wednesday
                },
             new SqlParameter()
                {
                    ParameterName = "@thursday",
                    Value = timetable. Thursday
                },
             new SqlParameter()
                {
                    ParameterName = "@friday",
                    Value = timetable. Friday
                },
             new SqlParameter()
                {
                    ParameterName = "@saturday",
                    Value = timetable. Saturday
                }
       };
       _dbClient.InvokeParameters(query, parameters);
    }
    
    public void UpdateTimeTable(TimeTable timetable)
    {
        var query = "UPDATE Time_Table SET      Monday  =  @monday  ,      Tuesday  =  @tuesday  ,      Wednesday  =  @wednesday  ,      Thursday  =  @thursday  ,      Friday  =  @friday  ,      Saturday  =  @saturday      Where Teacher_Id  =  @teacher_id";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@teacher_id",
                    Value = timetable. TeacherId
                },
             new SqlParameter()
                {
                    ParameterName = "@monday",
                    Value = timetable. Monday
                },
             new SqlParameter()
                {
                    ParameterName = "@tuesday",
                    Value = timetable. Tuesday
                },
             new SqlParameter()
                {
                    ParameterName = "@wednesday",
                    Value = timetable. Wednesday
                },
             new SqlParameter()
                {
                    ParameterName = "@thursday",
                    Value = timetable. Thursday
                },
             new SqlParameter()
                {
                    ParameterName = "@friday",
                    Value = timetable. Friday
                },
             new SqlParameter()
                {
                    ParameterName = "@saturday",
                    Value = timetable. Saturday
                },
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteTimeTable(int id)
    {
        var query = "Delete From Time_Table where Teacher_Id = @id";
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