using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalStore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public User(int id, string em, string n, string pas, int bal)
        {
            Id = id;
            Email = em;
            Name = n;
            Password = pas;
            Balance = bal;
        }
        public User()
        {

        }
    }
}
