using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;
namespace SMS.DAL
{

    public class HomeWorksService
    {
        private DbClient _dbClient = null;
        public HomeWorksService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetHomeWorksDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from HomeWork";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public HomeWork GetHomeWork(HomeWork homework)
       {
        var query = "SELECT * FROM HomeWork WHERE Student_Id ='" + homework.Id + "'";
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                    homework.StudentId = data.Rows[0].Field<System.Int32>("Student_Id");
                    homework.Monday = data.Rows[0].Field<System.String>("Monday");
                    homework.Tuesday = data.Rows[0].Field<System.String>("Tuesday");
                    homework.Wednesday = data.Rows[0].Field<System.String>("Wednesday");
                    homework.Thursday = data.Rows[0].Field<System.String>("Thursday");
                    homework.Friday = data.Rows[0].Field<System.String>("Friday");
                    homework.Saturday = data.Rows[0].Field<System.String>("Saturday");
                }
            });
            return homework;
       }
    
    public void InsertHomeWork(HomeWork homework)
    {
       var query = "INSERT INTO HomeWork(     Student_Id ,    Monday ,    Tuesday ,    Wednesday ,    Thursday ,    Friday ,    Saturday   )"+
                   "VALUES (    @student_id ,    @monday ,    @tuesday ,    @wednesday ,    @thursday ,    @friday ,    @saturday   );";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@student_id",
                    Value = homework. StudentId
                },
             new SqlParameter()
                {
                    ParameterName = "@monday",
                    Value = homework. Monday
                },
             new SqlParameter()
                {
                    ParameterName = "@tuesday",
                    Value = homework. Tuesday
                },
             new SqlParameter()
                {
                    ParameterName = "@wednesday",
                    Value = homework. Wednesday
                },
             new SqlParameter()
                {
                    ParameterName = "@thursday",
                    Value = homework. Thursday
                },
             new SqlParameter()
                {
                    ParameterName = "@friday",
                    Value = homework. Friday
                },
             new SqlParameter()
                {
                    ParameterName = "@saturday",
                    Value = homework. Saturday
                },
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    
    public void UpdateHomeWork(HomeWork homework)
    {
        var query = "UPDATE HomeWork SET            Monday  =  @monday  ,      Tuesday  =  @tuesday  ,      Wednesday  =  @wednesday  ,      Thursday  =  @thursday  ,      Friday  =  @friday  ,      Saturday  =  @saturday      Where Student_Id  =  @student_id";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@student_id",
                    Value = homework. StudentId
                },
             new SqlParameter()
                {
                    ParameterName = "@monday",
                    Value = homework. Monday
                },
             new SqlParameter()
                {
                    ParameterName = "@tuesday",
                    Value = homework. Tuesday
                },
             new SqlParameter()
                {
                    ParameterName = "@wednesday",
                    Value = homework. Wednesday
                },
             new SqlParameter()
                {
                    ParameterName = "@thursday",
                    Value = homework. Thursday
                },
             new SqlParameter()
                {
                    ParameterName = "@friday",
                    Value = homework. Friday
                },
             new SqlParameter()
                {
                    ParameterName = "@saturday",
                    Value = homework. Saturday
                },
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteHomeWork(int id)
    {
        var query = "Delete From HomeWork where Student_Id  =  @student_id";
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
