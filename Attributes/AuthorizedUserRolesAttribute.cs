using System;
using System.Collections.Generic;

namespace Realtair.Framework.Web.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class AuthorizedUserRolesAttribute : Attribute
    {
        // Fields
        public IEnumerable<int> UserRoles { get; set; }

        // Constructors
        public AuthorizedUserRolesAttribute(params int[] userRoles)
        {
            UserRoles = userRoles;
        }
    }
}