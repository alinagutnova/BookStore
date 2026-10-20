using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class User
    {
        private static int count = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public User(string name, string email, string password) 
        { 
            Id = ++count;
            Name = name;
            Email = email;
            Password = password;
        }        
    }
}
