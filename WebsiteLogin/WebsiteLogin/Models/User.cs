using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteLogin.Models
{
    class User
    {
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set
            {
                if (CheckUsername(value))
                {
                    this._username = value;
                }
            }
        }
        public string Password { get => _password;
            set {
                if (CheckPassword(value))
                {
                    this._password = value;
                }
            } }

        public bool CheckUsername(string str)
        {
                if (str.Length > 6)
                {
                return true;
                }
            return false;
        }

        public bool CheckPassword(string  str)
        {
            bool check = false;
            bool check2 = false;
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                {
                    check = true;
                }
                if (char.IsUpper(item))
                {
                    check2 = true;
                }

                if (check && check2)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
