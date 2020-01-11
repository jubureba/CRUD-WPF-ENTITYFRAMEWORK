
using GRUDcomEntityFramework.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRUDcomEntityFramework.Login_Page.code.Register
{
    public class User 
    {
        private string _username;
        private string _email;
        private string _password;


        public string Username { get => _username; set => _username = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }


        
    }


}
