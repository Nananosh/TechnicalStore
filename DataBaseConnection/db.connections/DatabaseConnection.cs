using System;
using System.Data.SQLite;
using TechnicalStore.Models;

namespace TechnicalStore.DataBaseConnection.db.connections
{
    public static class DatabaseConnection
    {
        private readonly static SQLiteConnection _connection =
            DatabaseConnectionManager.GetSqlConnection().OpenAndReturn();
        public static SQLiteDataReader GetAllProduct()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select * from product";
            return command.ExecuteReader();
        }
        public static void AddProduct(Product product)
        {
         
                using var command = _connection.CreateCommand();
                command.Connection = _connection;
                command.CommandText = $"INSERT INTO product(name,description,image,price,availability) VALUES (:_name,:_description,:_image,:_price,:_availability);";
                command.Parameters.AddWithValue("_name", product.Name);
                command.Parameters.AddWithValue("_description", product.Description);
                command.Parameters.AddWithValue("_image", product.Image);
                command.Parameters.AddWithValue("_price", product.Price);
                command.Parameters.AddWithValue("_availability", 1);
                Console.WriteLine(command.CommandText);
                command.ExecuteNonQuery();
            
           
        }
        public static void InsertProfile(User user)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"INSERT INTO profiles(email,name,password,balanace) VALUES (:email,:name,:password,:balanace);";
            command.Parameters.AddWithValue("email", user.Email);
            command.Parameters.AddWithValue("name", user.Name);
            command.Parameters.AddWithValue("password", user.Password);
            command.Parameters.AddWithValue("balanace", 0);
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }
        public static SQLiteDataReader GetAllProfileInformation()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select id,email,name,password,balanace from profiles";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetProfileInformation(int id)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select id,email,name,password,balanace from profiles where id={id}";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetBasket(int profileId)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select  profile_id,product_id from basket where profile_id={profileId}";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetBasket()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"select  profile_id,product_id from basket";
            return command.ExecuteReader();
        }
        public static void AddToBasket(int profileId, int productId)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"INSERT INTO basket(profile_id,product_id) VALUES (:profile_id,:product_id);";
            command.Parameters.AddWithValue("profile_id", profileId);
            command.Parameters.AddWithValue("product_id", productId);
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }


        public static void RemoveFromBasket(int productId)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"DELETE FROM basket  where  product_id={productId}";
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }
        public static void RemoveFromBasket(int profileid, int productId)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"DELETE FROM basket  where profile_id={profileid} and product_id={productId}";
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }

        public static void BuyProduct(Product product)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"UPDATE product SET availability=0 where id={product.Id}";
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }
        public static void PutMoney(User user, int total)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"UPDATE profiles SET balanace={user.Balance-total} where id={user.Id}";
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
        }
        public static SQLiteDataReader GetProfileBalanace(int profileId)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"SELECT balanace FROM profiles WHERE id={profileId}";
            return command.ExecuteReader();
        }
    }
}