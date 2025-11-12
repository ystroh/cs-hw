using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Users
    {
        public string name;
        public string password;
        public string email;

        public Users(string name , string password, string mail) {
            this.name = name;
            this.password = password;
            this.email = mail;
        
        }
    }
}
