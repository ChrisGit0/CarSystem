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
        public List<User> GetAllUsers()
        {
            using (CarsDBEntities db = new CarsDBEntities())
            {
                return db.Users.ToList();
            }
        }
       public bool CheckIfRegistered(string username, string password)
        { 
         using (CarsDBEntities db = new CarsDBEntities()) 
            
            {
                return db.Users.ToList().Where(u => u.UserName == username &&
                u.Password == password).Any();
            
            }
        }

        public void RegisterUser(string username, string password)
        {
            using (CarsDBEntities db = new CarsDBEntities())
            {
                User u = new User();
                if (!db.Users.ToList().Any())
                {
                    u.Id = 1;
                }
                else
                {
                    u.Id = db.Users.ToList().LastOrDefault().Id + 1;

                }
                u.UserName = username;
                u.Password = password;
                db.Users.Add(u);
                db.SaveChanges();
            }
        }
        public void DeleteUser(int id)
        {
            using (CarsDBEntities db = new CarsDBEntities())
            {
               //to do
            }
        }
    }
}
