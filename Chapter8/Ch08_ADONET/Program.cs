using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace Ch08_ADONET
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=true;");
            connection.Open();
            Console.WriteLine($"The connection is {connection.State}");

            Console.WriteLine("Original list of categories");
            ListCategories(connection);

            Console.WriteLine();
            Console.WriteLine("Enter a new category name:");
            var newCategory = Console.ReadLine();

            if (newCategory.Length > 15)
            {
                newCategory = newCategory.Substring(0, 15);
            }

            AddNewCategory(connection, newCategory);

            Console.WriteLine("List of categories after inserting:");
            ListCategories(connection);

            RemoveCategory(connection, newCategory);

            Console.WriteLine("List of categories after deleting:");
            ListCategories(connection);

            connection.Close();
            Console.WriteLine($"The connection is {connection.State}");

            Console.ReadLine();
        }

        // A method we will call three times to list the categories
        private static void ListCategories(SqlConnection connection)
        {
            var getCategories = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories", connection);

            using (var reader = getCategories.ExecuteReader())
            {
                // Find out the index positions of the columns that you want to read
                int indexOfID = reader.GetOrdinal("CategoryID"); // Index of the column CategoryID (0)
                int indexOfName = reader.GetOrdinal("CategoryName"); //Index of the column CategoryName (1)

                while (reader.Read())
                {
                    // Use the typed GetXXX methods to efficiently read the column values
                    Console.WriteLine($"{reader.GetInt32(indexOfID)} : {reader.GetString(indexOfName)}");
                }
            }
        }

        private static void AddNewCategory(SqlConnection connection, string category)
        {
            var insertCategory = new SqlCommand($"INSERT INTO Categories(CategoryName) VALUES (@NewCategoryName)", connection);
            insertCategory.Parameters.AddWithValue("@NewCategoryName", category);

            var rowsAffected = insertCategory.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} row(s) where inserted.");
        }

        private static void RemoveCategory(SqlConnection connection, string category)
        {
            var removeCategory = new SqlCommand($"DELETE FROM Categories WHERE CategoryName = @DeleteCategoryName", connection);
            removeCategory.Parameters.AddWithValue("@DeleteCategoryName", category);

            var rowsAffected = removeCategory.ExecuteNonQuery();
            Console.WriteLine($"{rowsAffected} row(s) where deleted.");
        }
    }
}