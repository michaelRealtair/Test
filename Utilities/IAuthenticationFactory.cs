using Realtair.Framework.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Realtair.Framework.Core.Web.Utilities
{
    public interface IAuthenticationFactory
    {
        IAuthentication CreateInstance(HttpResponseBase response, HttpRequestBase request, IPrincipal user);
    }
}
