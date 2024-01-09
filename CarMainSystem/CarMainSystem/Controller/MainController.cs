using CarMainSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMainSystem.Controller
{
    public class MainController
    {
       public bool CheckIfRegistered(string username, string password)
        { 
         using (CarsDBEntities db = new CarsDBEntities()) 
            
            {
                return db.Users.ToList().Where(u => u.UserName == username &&
                u.Password == password).Any();
            
            }
        }
    }
}
