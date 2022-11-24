using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Models
{
    internal class User
    {
        private string _username;
        private string _password;
        private bool _isSignedIn;
        private string _products;

        public string Username
        {
            get => _username;
            set 
            { 
                value = value.Trim();
                if(value.Length >= 6 && value.Length <= 25)
                {
                    _username = value;
                }
                 
            }
        }
        
        public string Password
        {
            get => _password;
            set 
            { 
                if(value.Length >= 8 && value.Length <= 25)
                {
                    _password = value;
                }
                
            }
        }
        
        public bool IsSignedIn
        {
            get => _isSignedIn;
            set { _isSignedIn = value; }
        }

        
        public string Products
        {
            get => _products;
            set { _products = value; }
        }

        public bool CheckPassword(string password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    return true;
                }
                if (char.IsUpper(password[i]))
                {
                    return true;
                }
                if (char.IsLower(password[i]))
                {
                    return true;
                }
                return false;
            }
        }

        public User(string username)
        {
            Username = username;
        }
        public User(string username , string password)
        {
            Username=username;
            Password = password;
        }
        public void Add(string[] products)
        {
            Array.Resize(ref products array,int new size)
        }

    }
}
