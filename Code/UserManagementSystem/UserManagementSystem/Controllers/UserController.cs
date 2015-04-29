using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.Http;
using UserManagementSystem.Models;
using Newtonsoft.Json;

namespace UserManagementSystem.Controllers
{
    public class UserController : ApiController
    {
        // GET: User
        public string Get()
        {
            using (var session = WebApiApplication.Store.OpenSession())
            {
                var users = session.Query<User>().ToList();
                return JsonConvert.SerializeObject(users);
            }

        }
        [HttpPost]
        public void Post(User user)
        {
            using (var session = WebApiApplication.Store.OpenSession())
            {
                session.Store(user);
                session.SaveChanges();
            }

        }
    }
}