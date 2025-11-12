using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class UsersManeger
    {
        public static List<Users> UsersList=new List<Users>();

       // Manager m= new Manager();       
        public static bool isConnect(string name, string password)
        {
            return  UsersList.Any(o => o.name == name &&
            o.password == password);
        }
        public static void addUser(string name, string password, string mail) 
        {
            Users user = new Users (name,password,mail);
            UsersList.Add(user);
        
        }
    
    
    }

    
}
