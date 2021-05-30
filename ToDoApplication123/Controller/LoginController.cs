using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApplication123.Model;

namespace ToDoApplication123.Controller
{
    class LoginController
    {
       public bool IsUserLogged(string username, string password)
        {
            using (ToDoEntities toDo = new ToDoEntities())
            {
                bool isLogged = false;
                foreach (var user in toDo.Users)
                {
                    if (user.Username == username && user.Password == password)
                    {
                        isLogged = true;
                    }
                }
                return isLogged;
            }
        }

        public bool IsAdmin(string username, string password)
        {
                bool isAdmin = false;
                {
                    if (username == "admin" && password == "adminpass")
                    {
                        isAdmin = true;
                    }
                }
                return isAdmin; 
        }

    }
}
