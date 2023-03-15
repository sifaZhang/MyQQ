using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MyQQ
{
    internal class DataOperator
    {
        private static string connectString = @"Server=tcp:sifa-dababase.database.windows.net,1433;Initial Catalog=db_MyQQ;Persist Security Info=False;User ID=sifa;Password=Zy31958058;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        public static SqlConnection connection = new SqlConnection(connectString);

        public int ExecSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,connection);
            if( connection.State == ConnectionState.Closed )
            {
                connection.Open();
            }
            
            object objData = cmd.ExecuteScalar();
            int num = Convert.ToInt32(objData is DBNull ? 0 : objData);
            connection.Close();

            return num;
        }

        public int ExecSQLResult(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            int result = cmd.ExecuteNonQuery();
            connection.Close();

            return result;
        }

        public DataSet GetDataSet(string strSql)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSql, connection);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            return ds;
        }

        public SqlDataReader GetDataReader(string strSql)
        {
            SqlCommand sqlCommand = new SqlCommand(strSql,connection);
            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }
    }
}
