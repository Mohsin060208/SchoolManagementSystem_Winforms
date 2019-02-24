using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;
namespace SMS.DAL
{

    public class TeachersService
    {
        private DbClient _dbClient = null;
        public TeachersService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetTeachersDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from Teacher";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public Teacher GetTeacher(Teacher teacher)
       {
        var query = "SELECT * FROM Teacher WHERE Id = '" + teacher.Id + "'";
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                           teacher.Name  = data.Rows[0].Field< System.String >("Name");
                         teacher.Gender = data.Rows[0].Field< System.String >("Gender");
                           teacher.Phone  = data.Rows[0].Field< System.String >("Phone");
                           teacher.Address = data.Rows[0].Field<System.String>("Address");
                           teacher.Salary = data.Rows[0].Field<System.Int32>("Salary");
                }
            });
            return teacher;
       }
    
    public void InsertTeacher(Teacher teacher)
    {
       var query = "INSERT INTO Teacher(     Name ,    Gender ,    Phone ,    Address, Salary   )"+
                   "VALUES (    @name ,    @gender ,    @phone ,    @address , @Salary  );";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = teacher. Name
                },
             new SqlParameter()
                {
                    ParameterName = "@gender",
                    Value = teacher. Gender
                },
             new SqlParameter()
                {
                    ParameterName = "@phone",
                    Value = teacher. Phone
                },
             new SqlParameter()
                {
                    ParameterName = "@address",
                    Value = teacher. Address
                },
                new SqlParameter()
                {
                    ParameterName = "@salary",
                    Value = teacher.Salary
                }
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    
    public void UpdateTeacher(Teacher teacher)
    {
       var query = "UPDATE Teacher SET      Name  =  @name  ,      Gender  =  @gender  ,      Phone  =  @phone  ,      Address  =  @address, Salary = @salary      Where Id = @id;";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = teacher. Name
                },
             new SqlParameter()
                {
                    ParameterName = "@gender",
                    Value = teacher. Gender
                },
             new SqlParameter()
                {
                    ParameterName = "@phone",
                    Value = teacher. Phone
                },
             new SqlParameter()
                {
                    ParameterName = "@address",
                    Value = teacher. Address
                },
              new SqlParameter(){
                  ParameterName = "@Id",
                  Value = teacher.Id
                },
                new SqlParameter()
                {
                    ParameterName = "@salary",
                    Value = teacher.Salary
                }
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteTeacher(int id)
    {
        var query = "Delete From Teacher where Id = @id";
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
