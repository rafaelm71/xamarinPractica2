using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(){}
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool Checkinfo()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
