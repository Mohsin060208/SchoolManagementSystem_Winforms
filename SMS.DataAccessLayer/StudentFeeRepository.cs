using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;
namespace SMS.DAL
{

    public class StudentFeesService
    {
        private DbClient _dbClient = null;
        public StudentFeesService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetStudentFeesDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from Student_Fee";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public StudentFee GetStudentFee(StudentFee studentFee)
       {
        var query = "SELECT * FROM Student_Fee WHERE StudentId ='" + studentFee.StudentId + "'";
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                           studentFee.TotalFee  = data.Rows[0].Field< System.Int32 >("Total_Fee");
                           studentFee.RemainingDues  = data.Rows[0].Field< System.Int32 >("Remaining_Dues");
                           studentFee.Fine  = data.Rows[0].Field< System.Int32 >("Fine");
                           studentFee.TransportDues  = data.Rows[0].Field< System.Int32 >("Transport_Dues");
                           studentFee.DueDate  = data.Rows[0].Field< System.DateTime >("Due_Date");
                           studentFee.LastDate  = data.Rows[0].Field< System.DateTime >("Last_Date");
                           studentFee.TransportDues = data.Rows[0].Field<System.Int32>("Transport_Dues");
                }
            });
            return studentFee;
       }
    
    public void InsertStudentFee(StudentFee studentfee)
    {
       var query = "INSERT INTO Student_Fee(   Student_Id ,    Total_Fee ,    Remaining_Dues ,    Fine ,    Transport_Dues ,    Due_Date ,    Last_Date    )"+
                   "VALUES (  @student_id ,    @total_fee ,    @remaining_dues ,    @fine ,    @transport_dues ,    @due_date ,    @last_date    );";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@student_id",
                    Value = studentfee. StudentId
                },
             new SqlParameter()
                {
                    ParameterName = "@total_fee",
                    Value = studentfee. TotalFee
                },
             new SqlParameter()
                {
                    ParameterName = "@remaining_dues",
                    Value = studentfee. RemainingDues
                },
             new SqlParameter()
                {
                    ParameterName = "@fine",
                    Value = studentfee. Fine
                },
             new SqlParameter()
                {
                    ParameterName = "@transport_dues",
                    Value = studentfee. TransportDues
                },
             new SqlParameter()
                {
                    ParameterName = "@due_date",
                    Value = studentfee. DueDate.ToShortDateString()
                },
             new SqlParameter()
                {
                    ParameterName = "@last_date",
                    Value = studentfee. LastDate.ToShortDateString()
                },
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    
    public void UpdateStudentFee(StudentFee studentfee)
    {
        var query = "UPDATE Student_Fee SET      Total_Fee  =  @total_fee  ,      Remaining_Dues  =  @remaining_dues  ,      Fine  =  @fine  ,      Transport_Dues  =  @transport_dues  ,      Due_Date  =  @due_date  ,      Last_Date  =  @last_date  ,      Where Student_Id  =  @student_id ";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@student_id",
                    Value = studentfee. StudentId
                },
             new SqlParameter()
                {
                    ParameterName = "@total_fee",
                    Value = studentfee. TotalFee
                },
             new SqlParameter()
                {
                    ParameterName = "@remaining_dues",
                    Value = studentfee. RemainingDues
                },
             new SqlParameter()
                {
                    ParameterName = "@fine",
                    Value = studentfee. Fine
                },
             new SqlParameter()
                {
                    ParameterName = "@transport_dues",
                    Value = studentfee. TransportDues
                },
             new SqlParameter()
                {
                    ParameterName = "@due_date",
                    Value = studentfee. DueDate
                },
             new SqlParameter()
                {
                    ParameterName = "@last_date",
                    Value = studentfee. LastDate
                },
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteStudentFee(int id)
    {
        var query = "Delete From Student_Fee where Student_Id = @id;";
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
