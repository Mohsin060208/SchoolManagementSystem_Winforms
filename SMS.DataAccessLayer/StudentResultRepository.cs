using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;

namespace SMS.DAL
{
    public class StudentResultsService
    {
        private DbClient _dbClient = null;
        public StudentResultsService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetStudentResultsDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from Student_Result";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public StudentResult GetStudentResult(StudentResult studentresult)
       {
        var query = "SELECT * FROM Student_Result WHERE StudentId ='" + studentresult.StudentId + "'";
            
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                        studentresult.TotalMarks = data.Rows[0].Field<System.Int32>("TotalMarks");
                           studentresult.ObtainedMarks  = data.Rows[0].Field< System.Int32 >("ObtainedMarks");
                           studentresult.Percentage  = data.Rows[0].Field< System.String >("Percentage");
                }
            });
            return studentresult;
       }

       public void InsertStudentResult(StudentResult studentresult)
       {
           var query = "INSERT INTO Student_Result (TotalMarks, ObtainedMarks, Percentage, StudentId) VALUES (@totalmarks, @obtainedmarks, @percentage, @studentid) ";
           List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@totalmarks",
                    Value = studentresult.TotalMarks
                },
             new SqlParameter()
                {
                    ParameterName = "@obtainedmarks",
                    Value = studentresult.ObtainedMarks
                },
             new SqlParameter()
                {
                    ParameterName = "@percentage",
                    Value = studentresult.Percentage
                },
                new SqlParameter(){
                    ParameterName = "@studentid",
                    Value = studentresult.StudentId
}
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    
    public void UpdateStudentResult(StudentResult studentresult)
    {
        var query = "UPDATE Student_Result SET TotalMarks  =  @totalmarks  ,      ObtainedMarks  =  @obtainedmarks  ,      Percentage  =  @percentage Where StudentId  =  @studentid ";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@totalmarks",
                    Value = studentresult.TotalMarks
                },
             new SqlParameter()
                {
                    ParameterName = "@obtainedmarks",
                    Value = studentresult.ObtainedMarks
                },
             new SqlParameter()
                {
                    ParameterName = "@percentage",
                    Value = studentresult.Percentage
                },
                new SqlParameter(){
                    ParameterName = "@studentid",
                    Value = studentresult.StudentId
                }
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteStudentResult(int id)
    {
        var query = "Delete From Student_Result where StudentId = @id;";
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
