using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
        public ApplicationRole()
        {

        }
        //overload ettim..
        public ApplicationRole(string rolename,string description)
        {
            this.Description = description;
        }
    }
}