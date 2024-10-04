using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG272_Project_Milestone2.BusinessLogic
{
    internal class Authentication
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAuthenticated { get; set; }

        public Authentication(string username, string password, bool isAuthenticated)
        {
            Username = username;
            Password = password;
            IsAuthenticated = isAuthenticated;
        }
        public override string ToString()
        {
            return $"Username: {Username} Psssword: {Password} Authenticated: {IsAuthenticated}";
        }
    }
}
