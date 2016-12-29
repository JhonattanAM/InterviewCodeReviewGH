using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCodeReview
{
  public class DatabaseOperation
    {
      static DatabaseOperation databaseOperation = null;

      private DatabaseOperation()
      { 
      
      }

      public static DatabaseOperation getDatabaseInstance()
      {
          if (databaseOperation == null)
          {
              return new DatabaseOperation();
          }

          return databaseOperation;
      }

      public void ExecuteSQLConection(string message, int idType)
      {
          SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings[Constant.ConnectionString]);
          string sqlCommand = string.Format("Insert into Log Values('{0}', {1})", message, idType.ToString());
          SqlCommand command = new SqlCommand(sqlCommand);
          command.Connection = connection;
          connection.Open();
          command.ExecuteNonQuery();
      }

    }
}
