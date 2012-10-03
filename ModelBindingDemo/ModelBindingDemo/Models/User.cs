using System;
using System.Collections.Generic;

namespace ModelBindingDemo.Models
{
    public class User
    {
        public List<Role> roles = new List<Role>();
        private bool isApproved = false;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Address HomeAddress { get; set; }
        public bool IsApproved
        {
            get { return isApproved; }
            set { isApproved = value; }
        }
        public List<Role> Roles
        {
            get { return roles; }
        }

        public void AddRole(Role newRole)
        {
            roles.Add(newRole);
        }
    }
}