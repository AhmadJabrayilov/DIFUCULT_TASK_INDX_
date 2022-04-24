using System;
using System.Collections.Generic;
using System.Text;

namespace Intf_Indx_Excp.Models
{
    internal class User : IAccount
    {
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {

                }
            }
        }



        public User(string fullname, string email)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Email = email;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} / Fullnama: {Fullname} / Email: {Email} ");
        }

        public bool PasswordChecker(string password)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;
            if ( password.Length >= 8)
            {
                foreach (var ch in password)
                {
                    if (char.IsDigit(ch))
                    {
                        hasDigit = true;
                    }
                    if (char.IsUpper(ch))
                    {
                        hasUpper = true;
                    }
                    if (char.IsLower(ch))
                    {
                        hasLower = true;
                    }
                }
            }
            return true;
        }

     

      

    }
}
