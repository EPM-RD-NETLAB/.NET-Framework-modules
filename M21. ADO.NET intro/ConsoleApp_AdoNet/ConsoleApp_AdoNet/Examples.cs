using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AdoNet
{
    [TestClass]
    public class Examples
    {
        [TestMethod]
        public void A_SimpleExample()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\mentoring\lectures\AdoNet\ConsoleApp_AdoNet\Test.mdf;Integrated Security=True;Connect Timeout=30";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM Items", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        Console.WriteLine($"    {reader[0]}; {reader[1]}");
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void B_ConnectionStringBuilder()
        {
            var builder = new SqlConnectionStringBuilder();
            builder["Data Source"] = "(LocalDB)\\MSSQLLocalDB";
            builder["AttachDbFilename"] = @"C:\Projects\mentoring\lectures\AdoNet\ConsoleApp_AdoNet\Test.mdf;";
            builder["integrated Security"] = true;
            Console.WriteLine(builder.ConnectionString);
        }

        [TestMethod]
        public void C_ConnectionStringFromConfig()
        {
            Console.WriteLine(ConfigurationManager.ConnectionStrings["myDB"]);
        }

        [TestMethod]
        public void D_CommandDetails()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\mentoring\lectures\AdoNet\ConsoleApp_AdoNet\Test.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Items WHERE Id > @Id";
                    command.CommandType = CommandType.Text;

                    var parameter = command.CreateParameter();
                    // new SqlParameter() >_<
                    parameter.ParameterName = "@Id";
                    parameter.SqlDbType = SqlDbType.Int; //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
                    parameter.Direction = ParameterDirection.Input;
                    parameter.Value = 1;
                    command.Parameters.Add(parameter);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        Console.WriteLine($"    {reader[0]}; {reader[1]}");
                    reader.Close();
                }
            }
        }

        [TestMethod]
        public void E_ExecuteScalar()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\mentoring\lectures\AdoNet\ConsoleApp_AdoNet\Test.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Count(*) FROM Items";

                    object count = command.ExecuteScalar();
                    Console.WriteLine(count);
                }

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT null";

                    object count = command.ExecuteScalar();
                    Console.WriteLine(count.GetType());
                }
            }
        }

        [TestMethod]
        public void F_ExecuteNonQuery()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\mentoring\lectures\AdoNet\ConsoleApp_AdoNet\Test.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Items VALUES (3, 'Butter')";

                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine(affected);
                }

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Items SET Name = 'Margarine' WHERE Id = 3";

                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine(affected);
                }

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Items WHERE Id = 3";

                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine(affected);
                }
            }
        }

        [TestMethod]
        public void G_Transactions()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\mentoring\lectures\AdoNet\ConsoleApp_AdoNet\Test.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                var transaction = connection.BeginTransaction(); //IsolationLevel

                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Transaction = transaction;
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Items VALUES (4, 'Lemon')";

                        int affected = command.ExecuteNonQuery();
                        Console.WriteLine(affected);
                    }

                    using (var command = new SqlCommand())
                    {
                        command.Transaction = transaction;
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Items VALUES (5, 'Cheese')";

                        int affected = command.ExecuteNonQuery();
                        Console.WriteLine(affected);
                    }

                    using (var command = new SqlCommand("SELECT * FROM Items", connection))
                    {
                        command.Transaction = transaction;
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read()) Console.WriteLine($"  {reader[0]}; {reader[1]}");
                        reader.Close();
                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Items WHERE Id in (4, 5)";

                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine(affected);
                }
            }
        }

        [TestMethod]
        public void I_ExecuteStoredProcedure()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\mentoring\lectures\AdoNet\ConsoleApp_AdoNet\Test.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
CREATE PROCEDURE CreateBreakfast
    @Drink NVARCHAR(255),
    @Message NVARCHAR(255) OUT
AS
    SELECT Name FROM Items
    UNION ALL
    SELECT @Drink

    SELECT Name FROM Items
    UNION ALL
    SELECT @Drink

    SET @Message = 'bon appetit'
";
                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine(affected);
                }

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CreateBreakfast";
                    {
                        var parameter = command.CreateParameter();
                        parameter.ParameterName = "@Drink";
                        parameter.SqlDbType = SqlDbType.NVarChar;
                        parameter.Size = 255;
                        parameter.Value = "Tea";
                        command.Parameters.Add(parameter);
                    }
                    {
                        var parameter = command.CreateParameter();
                        parameter.ParameterName = "@Message";
                        parameter.SqlDbType = SqlDbType.NVarChar;
                        parameter.Size = 255;
                        parameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(parameter);
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        Console.WriteLine($"{reader.GetName(0)}");
                        while (reader.Read())
                            Console.WriteLine($"    {reader[0]};");
                        reader.NextResult();
                    }

                    Console.WriteLine($"    {command.Parameters[1].Value}");

                    reader.Close();
                }

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DROP PROCEDURE CreateBreakfast";
                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine(affected);
                }
            }
        }

        [TestMethod]
        public void J_DataSet()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\mentoring\lectures\AdoNet\ConsoleApp_AdoNet\Test.mdf;Integrated Security=True;Connect Timeout=30";

            var dataSet = new DataSet();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var adapter = new SqlDataAdapter("SELECT * FROM Items", connection))
                    adapter.Fill(dataSet, "Items");
            }


            DataTable itemsTable = dataSet.Tables["Items"];

            foreach (DataRow row in itemsTable.Rows)
            {
                foreach (DataColumn column in itemsTable.Columns)
                    Console.Write($"    {row[column]}");
                Console.WriteLine();
            }

            var newRow = itemsTable.NewRow();
            newRow["Id"] = 3;
            newRow["Name"] = "Buritto";
            itemsTable.Rows.Add(newRow);


        }
    }
}
