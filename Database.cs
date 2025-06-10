using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public class Database
    {
        private static readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "localhost\\SQLEXPRESS",
            InitialCatalog = "практика1",
            IntegratedSecurity = true,
        };

        public static void ExecuteNonQuery(SqlCommand command)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString))
            {
                command.Connection = sqlConnection;
                try
                {
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запрос выполнен успешно", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static object ExecuteWithResult(SqlCommand command)
        {
            object result = null;

            using (SqlConnection sqlConnection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString))
            {
                command.Connection = sqlConnection;
                try
                {
                    sqlConnection.Open();
                    result = command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }

        public static DataTable ExecuteWithTable(SqlCommand command)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString))
            {
                command.Connection = sqlConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dataTable;
        }
    }
}
