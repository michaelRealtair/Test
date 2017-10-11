using Realtair.Framework.Core.Actions.Providers;
using Realtair.Framework.Core.Data;
using Realtair.Framework.Core.Interfaces;
using Realtair.Framework.Core.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Realtair.Framework.Core.Web.Controllers
{
    public class SearchController : BaseController
    {
        public SearchController(IAuthenticationFactory authenticationFactory)
            : base(authenticationFactory)
        {
        }

        //[Route("{entityTypeName}/search")]
        public ActionResult Search(string entityTypeName, string query, bool allowMultipleSelection = false, string text = "")
        {
            if (Request.HttpMethod == "GET")
            {
                var providerType = CoreExtensions.GetEntityType(entityTypeName).GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ISearchable<>)).GetGenericArguments()[0];
                var provider = (ISearchProvider)Activator.CreateInstance(providerType);
                var searchResults = provider.Search(DbContext, User, query, text);
                var model = new SearchViewModel { Provider = provider, Results = searchResults };

                return View(model);
            }
            else
            {
                var providerType = CoreExtensions.GetEntityType(entityTypeName).GetInterfaces().Last(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ISearchable<>)).GetGenericArguments()[0];
                var provider = (ISearchProvider)Activator.CreateInstance(providerType);

                var searchResults = provider.Search(DbContext, User, query, text);
                searchResults.AllowMultipleSelection = allowMultipleSelection;
                
                return View("Results", searchResults);
            }
        }

        //[Route("{entityTypeName}/search"), HttpPost]
        public ActionResult Results(string entityTypeName, string query, bool allowMultipleSelection = false, string text = "")
        {
            var providerType = CoreExtensions.GetEntityType(entityTypeName).GetInterfaces().Last(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ISearchable<>)).GetGenericArguments()[0];
            var provider = (ISearchProvider)Activator.CreateInstance(providerType);

            var searchResults = provider.Search(DbContext, User, query, text);
            searchResults.AllowMultipleSelection = allowMultipleSelection;

            if (!allowMultipleSelection)
                return View(searchResults);
            else
                return View(searchResults);
        }

        public class SearchViewModel
        {
            public ISearchProvider Provider { get; set; }
            public SearchResults Results { get; set; }
        }
    }
}