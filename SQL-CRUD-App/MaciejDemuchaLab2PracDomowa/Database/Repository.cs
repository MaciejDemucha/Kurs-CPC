using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaciejDemuchaLab2PracDomowa.Database
{

    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    public class Repository
    {

        private readonly SqlConnection _connection = new SqlConnection(MaciejDemuchaLab2PracaDomowa.Properties.Resources.ConnectionString);

        /// <summary>
        /// Metoda zwracająca produkty z tabeli Products
        /// </summary>
        /// <returns></returns>
        public DataTable GetProducts()
        {
            try
            {
                string query = "SELECT Products.*, Sex.Name, ProductTypes.Name, Colors.Name, Sports.Name, Producers.Name" +
                    "FROM Products " +
                    "JOIN Sex ON Products.SexId = Sex.Id " +
                    "JOIN ProductTypes ON Products.TypeId = ProductTypes.Id; " +
                    "JOIN Colors ON Products.ColorId = Colors.Id " +
                    "JOIN Sports ON Products.SportId = Sports.Id " +
                    "JOIN Producers ON Products.ProducerId = Producers.Id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }

       /// <summary>
       /// Metoda dodająca nowy produkt do tabeli products
       /// </summary>
       /// <param name="name"></param>
       /// <param name="size"></param>
       /// <param name="price"></param>
       /// <param name="sport"></param>
       /// <param name="type"></param>
       /// <param name="sex"></param>
       /// <param name="producer"></param>
       /// <param name="color"></param>
        public void AddProduct(string name, string size, int price, string sport, string type, string sex, string producer, string color)
        {
            string queryGetSport = "SELECT Id " +
                "FROM Sports " +
                $"WHERE Name = '{sport}';";
            string queryGetType = "SELECT Id " +
                "FROM ProductTypes " +
                $"WHERE Name = '{type}';";
            string queryGetSex = "SELECT Id " +
                "FROM Sex " +
                $"WHERE Name = '{sex}';";
            string queryGetProducer = "SELECT Id " +
                "FROM Producers " +
                $"WHERE Name = '{producer}';";
            string queryGetColor = "SELECT Id " +
                "FROM Sports " +
                $"WHERE Name = '{color}';";


            _connection.Open();

            SqlCommand commandGetSport = new SqlCommand(queryGetSport, _connection);
            SqlCommand commandGetType = new SqlCommand(queryGetType, _connection);
            SqlCommand commandGetSex = new SqlCommand(queryGetSex, _connection);
            SqlCommand commandGetProducer = new SqlCommand(queryGetProducer, _connection);
            SqlCommand commandGetColor = new SqlCommand(queryGetColor, _connection);

            int sportId = (int)commandGetSport.ExecuteScalar();
            int typeId = (int)commandGetType.ExecuteScalar();
            int sexId = (int)commandGetSex.ExecuteScalar();
            int producerId = (int)commandGetProducer.ExecuteScalar();
            int colorId = (int)commandGetColor.ExecuteScalar();

            string queryInsertProduct = "INSERT INTO Products " +
                 $"VALUES ('{producerId}', '{sexId}', '{colorId}', '{sportId}', '{typeId}', '{name}', {size}', '{price}')";

            SqlCommand commandInsertProduct = new SqlCommand(queryInsertProduct, _connection);
            commandInsertProduct.ExecuteNonQuery();

            _connection.Close();
        }

        /// <summary>
        /// Metoda usuwająca produkt z tabeli Products na podstawie jego Id
        /// </summary>
        /// <param name="productId"></param>
        public void DeleteProduct(int productId)
        {
            string queryDeleteProduct = "DELETE FROM products " +
                $"WHERE Id = {productId};";

            _connection.Open();

            SqlCommand commandDeleteProduct = new SqlCommand(queryDeleteProduct, _connection);
            commandDeleteProduct.ExecuteNonQuery();

            _connection.Close();
        }

        /// <summary>
        /// Metoda edytująca produkt o danym id
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="name"></param>
        /// <param name="size"></param>
        /// <param name="price"></param>
        /// <param name="sport"></param>
        /// <param name="type"></param>
        /// <param name="sex"></param>
        /// <param name="producer"></param>
        /// <param name="color"></param>
        public void EditProduct(int productId, string name, string size, int price, string sport, string type, string sex, string producer, string color)
        {
            string queryGetSport = "SELECT Id " +
                "FROM Sports " +
                $"WHERE Name = '{sport}';";
            string queryGetType = "SELECT Id " +
                "FROM ProductTypes " +
                $"WHERE Name = '{type}';";
            string queryGetSex = "SELECT Id " +
                "FROM Sex " +
                $"WHERE Name = '{sex}';";
            string queryGetProducer = "SELECT Id " +
                "FROM Producers " +
                $"WHERE Name = '{producer}';";
            string queryGetColor = "SELECT Id " +
                "FROM Sports " +
                $"WHERE Name = '{color}';";


            _connection.Open();

            SqlCommand commandGetSport = new SqlCommand(queryGetSport, _connection);
            SqlCommand commandGetType = new SqlCommand(queryGetType, _connection);
            SqlCommand commandGetSex = new SqlCommand(queryGetSex, _connection);
            SqlCommand commandGetProducer = new SqlCommand(queryGetProducer, _connection);
            SqlCommand commandGetColor = new SqlCommand(queryGetColor, _connection);

            int sportId = (int)commandGetSport.ExecuteScalar();
            int typeId = (int)commandGetType.ExecuteScalar();
            int sexId = (int)commandGetSex.ExecuteScalar();
            int producerId = (int)commandGetProducer.ExecuteScalar();
            int colorId = (int)commandGetColor.ExecuteScalar();

            string queryEditProduct = "UPDATE Products " +
                $"SET Name = '{name}', Size = '{size}', Price = '{price}', " +
                $"SportId = '{sportId}', TypeId = '{typeId}', SexId = '{sexId}', " +
                $"ProducerId = '{producerId}', ColorId = '{colorId}' " +
                $"WHERE Id = {productId};";

            SqlCommand commandEditProduct = new SqlCommand(queryEditProduct, _connection);
            commandEditProduct.ExecuteNonQuery();

            _connection.Close();
        }
        
    }
}
