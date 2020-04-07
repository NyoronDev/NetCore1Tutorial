using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ch12_GUITasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetProductsButtonClick(object sender, RoutedEventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=Northwind; Integrated Security=true;"))
            {
                connection.Open();
                var getProducts = new SqlCommand("WAITFOR DELAY '00:00:05'; SELECT ProductID, ProductName, UnitPrice FROM Products", connection);

                using (var reader = getProducts.ExecuteReader())
                {
                    var indexOfID = reader.GetOrdinal("ProductID");
                    var indexOfName = reader.GetOrdinal("ProductName");
                    var indexOfPrice = reader.GetOrdinal("UnitPrice");

                    while (reader.Read())
                    {
                        ProductsListBox.Items.Add($"{reader.GetInt32(indexOfID)}: {reader.GetString(indexOfName)} costs {reader.GetDecimal(indexOfPrice):C}");
                    }
                }
            }
        }
    }
}