using System.Linq;
using ToDoApplication123.Model;

namespace ToDoApplication.Controller
{
    public class RegistrationController
    {
        public void InsertUser(User user)
        {
            using (ToDoEntities toDo = new ToDoEntities())
            {
                toDo.Users.Add(user);
                toDo.SaveChanges();
            }
        }

        public bool IsUserRegistered(string username)
        {
            using (ToDoEntities toDo = new ToDoEntities())
            {
                bool isRegistered = false;
                foreach (var user in toDo.Users)
                {
                    if (user.Username == username)
                    {
                        isRegistered = true;
                    }
                }
                return isRegistered;
            }
        }
        public bool IsNotEmpty(string username, string first_name, string last_name, string password)
        {
                bool isNotEmpty = false;
                    if (username == null || first_name == null || last_name == null || password == null)
                    {
                        isNotEmpty = true;
                    }
                return isNotEmpty;
  
        }
    }
}


