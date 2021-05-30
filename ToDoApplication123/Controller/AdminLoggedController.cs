using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication123.Model;


namespace ToDoApplication123.Controller
{
    public class AdminLoggedController
    {
        public List<User> GetAllUsers()
        {
            using (ToDoEntities toDo = new ToDoEntities())
            {
                return toDo.Users.ToList();
            }
        }
    }
}
