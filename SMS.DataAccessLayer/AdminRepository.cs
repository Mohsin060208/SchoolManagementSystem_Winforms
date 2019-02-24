using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Database;
using SMS.Model;
namespace SMS
{

    public class AdminService
    {
        private DbClient _dbClient = null;
        public AdminService()
        {
            _dbClient = DbClient.CreateDbClient();
        }
        public DataTable GetLogínsDataTable(string query = null)
        {
            if (string.IsNullOrEmpty(query))
            {
                query = "Select * from Admin";
            }
            var dataTable = new DataTable();
            _dbClient.InvokeDataReader(query, data =>
            {
                dataTable = data;
            });
            return dataTable;
        }
       public bool GetLogín(Admin admin)
       {
        var query = "SELECT * FROM Admin where Username = '" + admin.Username + "'and Password = '" + admin.Password +"'";
           bool result = false;
             _dbClient.InvokeDataReader(query, data =>
            {
                if (data != null && data.Rows.Count > 0)
                {
                    result = true;
                }
            });
           return result;
       }
       public Admin Get(string username, string password)
       {
           Admin admin = new Admin();
           var query = "SELECT Username, Password FROM Admin where Username ='" + username + "' AND Password ='" + password + "'";
           _dbClient.InvokeDataReader(query, data =>
           {
               if (data != null && data.Rows.Count > 0)
               {
                   for (int i = 0; i < data.Rows.Count; i++)
                   {
                       admin.Username = data.Rows[i].Field<string>("Username");
                       admin.Password = data.Rows[i].Field<string>("Password");
                   }
               }
           });
           return admin; 
       }
    public void InsertLogín(Admin admin)
    {
       var query = "INSERT INTO Admin (Username, Password, Recovery_Name) VALUES(@username, @password, @nickname)";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@username",
                    Value = admin.Username
                },
             new SqlParameter()
                {
                    ParameterName = "@password",
                    Value = admin.Password
                },
                new SqlParameter(){
                    ParameterName = "@nickname",
                    Value = admin.RecoveryName
                }
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public Admin FindAccount(string nickname)
    {
        Admin admin = new Admin();
        var query = "SELECT Id, Username FROM Admin where Recovery_Name = '" + nickname + "'";
        _dbClient.InvokeDataReader(query, data =>
        {
            if (data != null && data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    admin.Id = data.Rows[i].Field<System.Int32>("Id");
                    admin.Username = data.Rows[i].Field<string>("Username");
                }
            }
        });
        return admin;
    }
    public void UpdateLogín(Admin admin)
    {
       var query = "UPDATE Admin SET  Username  =  @username,     Password  =  @password,     Recovery_Name  =  @nickname   Where Id = @id;";
       List<SqlParameter> parameters = new List<SqlParameter>
       {
             new SqlParameter()
                {
                    ParameterName = "@id",
                    Value = admin. Id
                },
             new SqlParameter()
                {
                    ParameterName = "@username",
                    Value = admin. Username
                },
             new SqlParameter()
                {
                    ParameterName = "@password",
                    Value = admin. Password
                },
             new SqlParameter()
                {
                    ParameterName = "@nickname",
                    Value = admin.RecoveryName
                },
       };
      
       _dbClient.InvokeParameters(query, parameters);
    }
    public void DeleteLogín(int id)
    {
        var query = "Delete From Admin where Id = @id;";
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
