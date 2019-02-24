using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;
namespace SMS.DAL
{

    public class StudentsService
    {
        private DbClient _dbClient = null;
        public StudentsService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetStudentsDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from Student";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public Student GetStudent(Student student)
       {
        var query = "SELECT * FROM Student WHERE Id = '" + student.Id + "'";
            List<Student> students = new List< Student >();
            
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                           student.Name  = data.Rows[0].Field< System.String >("Name");
                           student.FatherName  = data.Rows[0].Field< System.String >("FatherName");
                           student.Gender  = data.Rows[0].Field< System.String >("Gender");
                           student.Phone  = data.Rows[0].Field< System.String >("Phone");
                           student.Address  = data.Rows[0].Field< System.String >("Address");
                           student.Session  = data.Rows[0].Field< System.String >("Session");
                           student.AdminDate  = data.Rows[0].Field< System.DateTime >("AdminDate");
                           student.Dob  = data.Rows[0].Field< System.DateTime >("DOB");
                           student.Class  = data.Rows[0].Field< System.String >("Class");
                           student.Email = data.Rows[0].Field<System.String>("Email");
                }
            });
            return student;
       
       }
    
    public void InsertStudent(Student student)
    {
       var query = "INSERT INTO Student(     Name ,    FatherName ,    Gender ,    Phone ,    Address ,    Session ,        Class ,    Email, DOB, AdminDate   )"+
                   "VALUES (    @name ,    @fathername ,    @gender ,    @phone ,    @address ,    @session ,        @class ,    @email, @dob, @admindate   );";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = student. Name
                },
             new SqlParameter()
                {
                    ParameterName = "@fathername",
                    Value = student. FatherName
                },
             new SqlParameter()
                {
                    ParameterName = "@gender",
                    Value = student. Gender
                },
             new SqlParameter()
                {
                    ParameterName = "@phone",
                    Value = student. Phone
                },
             new SqlParameter()
                {
                    ParameterName = "@address",
                    Value = student. Address
                },
             new SqlParameter()
                {
                    ParameterName = "@session",
                    Value = student. Session
                },
             new SqlParameter()
                {
                    ParameterName = "@admindate",
                    Value = student. AdminDate.ToShortDateString()
                },
             new SqlParameter()
                {
                    ParameterName = "@dob",
                    Value = student. Dob.ToShortDateString()
                },
             new SqlParameter()
                {
                    ParameterName = "@class",
                    Value = student. Class
                },
             new SqlParameter()
                {
                    ParameterName = "@email",
                    Value = student. Email
                }
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    
    public void UpdateStudent(Student student)
    {
       var query = "UPDATE Student SET      Name  =  @name  ,      FatherName  =  @fathername  ,      Gender  =  @gender  ,      Phone  =  @phone  ,      Address  =  @address  ,      Session  =  @session  ,      AdminDate  =  @admindate  ,      DOB  =  @dob  ,      Class  =  @class  ,      Email  =  @email      Where Id = @id;";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = student. Name
                },
             new SqlParameter()
                {
                    ParameterName = "@fathername",
                    Value = student. FatherName
                },
             new SqlParameter()
                {
                    ParameterName = "@gender",
                    Value = student. Gender
                },
             new SqlParameter()
                {
                    ParameterName = "@phone",
                    Value = student. Phone
                },
             new SqlParameter()
                {
                    ParameterName = "@address",
                    Value = student. Address
                },
             new SqlParameter()
                {
                    ParameterName = "@session",
                    Value = student. Session
                },
             new SqlParameter()
                {
                    ParameterName = "@admindate",
                    Value = student. AdminDate.ToShortDateString()
                },
             new SqlParameter()
                {
                    ParameterName = "@dob",
                    Value = student. Dob.ToShortDateString()
                },
             new SqlParameter()
                {
                    ParameterName = "@class",
                    Value = student. Class
                },
             new SqlParameter()
                {
                    ParameterName = "@email",
                    Value = student. Email
                },
                new SqlParameter(){
                    ParameterName = "@id",
                    Value = student.Id
                }
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteStudent(int id)
    {
        var query = "Delete From Student where Id = @id;";
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