using Angularjs.UIRouting.WebApp.DataAccessLayer;
using Angularjs.UIRouting.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angularjs.UIRouting.WebApp.Controllers
{
    public class UserController : ApiController
    {
        DataContext db = new DataContext();
        [Route("api/User/search")]
        [HttpGet]
        public IEnumerable<User> SearchUsers(string searchText)
        {
            searchText = searchText ?? "";
           return db.Users
                .Where(x => x.FullName.Contains(searchText) ||
                        x.Country.Contains(searchText) ||
                        x.City.Contains(searchText)
                )
                .Take(20);
        }

        [Route("api/User/new")]
        [HttpGet]
        public User NewUser()
        {
            return new User();
        }

        [Route("api/User/detail/{id}")]
        [HttpGet]
        public User GetDetail(int Id)
        {
            return db.Users.FirstOrDefault(x=>x.UserId == Id);
        }

        [Route("api/User/Save")]
        [HttpPost]
        public User SaveUser(User User)
        {

            if (User.UserId > 0)
            {
                var dbUser = db.Users.FirstOrDefault(x => x.UserId == User.UserId);
                dbUser.FullName = User.FullName;
                dbUser.Address = User.Address;
                dbUser.City = User.City;
                dbUser.Country = User.Country;
                dbUser.ZipCode = User.ZipCode;
                db.SaveChanges();
                return dbUser;
            }
            else
            {
                db.Users.Add(User);
                db.SaveChanges();
                return User;
            }
        }

        [Route("api/User/delete/{id}")]
        [HttpPost]
        public void DeleteUser(int Id)
        {
            var User = db.Users.FirstOrDefault(x => x.UserId == Id);
            db.Users.Remove(User);
            db.SaveChanges();
        }
    }
}
