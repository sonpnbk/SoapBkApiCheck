using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SCheckDataAccess;

namespace SoapBkCheckAPI.Controllers
{
    public class UserController : ApiController
    {
        public User Get(Guid UserId)
        {
            using(SoapbkCheckEntities entities = new SoapbkCheckEntities())
            {
                return entities.Users.FirstOrDefault(e => e.UserId == UserId);
            }
        }
        public void Post(User user)
        {
            using(SoapbkCheckEntities entities = new SoapbkCheckEntities())
            {
                entities.Users.Add(user);
                entities.SaveChanges();
            }
        }
    }
}
