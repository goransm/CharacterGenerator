using System.Data;
using Microsoft.Data.SqlClient;

namespace CharacterLib
{
    class Dbase
    {
        private string _connectionString;
        private string _table;
        public Dbase(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable Fetch(string sqlQueryString = "Select * from Character")
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var dataAdapter = new SqlDataAdapter(sqlQueryString, _connectionString);
                var dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "randomTableNameForTestingPurposes");

                connection.Close();
                return dataSet.Tables["randomTableNameForTestingPurposes"];
            }
        }

        public void DeleteById(int id, string tableName = "Character")
        {
            _executeNonQuery($"Delete from {tableName} where id = {id}");
        }

        public void UpdateField(int id, string field, int value, string tableName = "Character")
        {
            _executeNonQuery($"UPDATE {tableName} SET {field} = {value} WHERE id = {id}");
        }

        public void UpdateField(int id, string field, string value, string tableName = "Character")
        {
            _executeNonQuery($"UPDATE {tableName} SET {field} = '{value}' WHERE id = {id}");
        }

        private void _executeNonQuery(string sqlString)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sqlString, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
