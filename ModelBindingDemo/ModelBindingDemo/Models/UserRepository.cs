using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBindingDemo.Models
{
    /// <summary>
    /// a very fake repository!
    /// </summary>
    public class UserRepository
    {
        public User GetSomeUser()
        {
            return new User
            {
                FirstName = "Sebastien",
                LastName = "Vettel",
                IsApproved = false
            };
        }
    }
}