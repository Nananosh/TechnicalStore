using System.Collections.Generic;
using System.Data.SQLite;
using TechnicalStore.DataBaseConnection.db.connections;
using TechnicalStore.Models;

namespace TechnicalStore.DataBaseConnection.Factory
{
    public static class Factory
    {
        public static List<Product> GetAllProduct(SQLiteDataReader dataReader)
        {
            List<Product> list = new List<Product>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var name= dataReader.GetString(1);
                var description = dataReader.GetString(2);
                var image = dataReader.GetString(3);
                var price = dataReader.GetInt32(4);
                var sold_out = dataReader.GetInt32(5);
                list.Add(new Product(id,name,description,image,price,sold_out));
                list.Reverse();
            }
            return list;
        }
        public static void AddProduct(Product product)
        {
            DatabaseConnection.AddProduct(product);
        }
        public static void InsertProfile(User user)
        {

            DatabaseConnection.InsertProfile(user);
        }
        public static void AddToBasket(int profileid, int productid)
        {
            DatabaseConnection.AddToBasket(profileid,productid);
        }
        public static List<User> GetAllProfileInformation(SQLiteDataReader dataReader)
        {
            List<User> list = new List<User>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var email = dataReader.GetString(1);
                var nick = dataReader.GetString(2);
                var password = dataReader.GetString(3);
                var balanace = dataReader.GetInt32(4);
                list.Add(new User(id, email, nick, password, balanace));
            }
            return list;
        }
        public static User GetProfileInformation(SQLiteDataReader dataReader)
        {
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var email = dataReader.GetString(1);
                 var nick = dataReader.GetString(2);
                var password = dataReader.GetString(3);
                var balanace = dataReader.GetInt32(4);
                return new User(id,email,nick,password, balanace);
            }
            return null;
           
           
        }
        public static List<Basket> GetBasket(SQLiteDataReader dataReader)
        {

            List<Basket> list = new List<Basket>();
            while (dataReader.Read())
            {
                var profile_Id = dataReader.GetInt32(0);
                var product_Id = dataReader.GetInt32(1);
                list.Add(new Basket(profile_Id, product_Id));
            }
            return list;
        }
        public static List<Basket> GetAllBasket(SQLiteDataReader dataReader)
        {

            List<Basket> list = new List<Basket>();
            while (dataReader.Read())
            {
                var profile_Id = dataReader.GetInt32(0);
                var product_Id = dataReader.GetInt32(1);
                list.Add(new Basket(profile_Id, product_Id));
            }
            return list;
        }
        public static void RemoveFromBasket(int productid)
        {

            DatabaseConnection.RemoveFromBasket(productid);
        }
        public static void RemoveFromBasket(int profileid, int productid)
        {

            DatabaseConnection.RemoveFromBasket(profileid,productid);
        }
        public static void BuyProduct(Product product)
        {

            DatabaseConnection.BuyProduct(product);
        }
        public static void PutMoney(User user, int total)
        {

            DatabaseConnection.PutMoney(user, total);
        }
        public static int GetProfileBalanace(SQLiteDataReader dataReader)
        {
            int balanace = 0;
            while (dataReader.Read())
            {
                balanace = dataReader.GetInt32(0);
            }
            return balanace;
        }
    }
    
}