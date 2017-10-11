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
        // Constructors
        public SearchController(IAuthenticationFactory authenticationFactory)
            : base(authenticationFactory)
        {
        }

        // Private Methods
        private ISearchProvider GetProvider(string entityTypeName)
        {
            var entityType = CoreExtensions.GetEntityType(entityTypeName);
            var types = entityType.GetInterfaces();
            var providerType = (
                // Get the non-inherited provider types first...
                types
                    .Except(entityType.BaseType.GetInterfaces())
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ISearchable<>))     
                ??
                // If there are no non-inherited provider types, get the inherited ones...
                types.FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ISearchable<>))
            ).GetGenericArguments()[0];

            return (ISearchProvider)Activator.CreateInstance(providerType);
        }
        private SearchResults GetSearchResults(ISearchProvider provider, string query, string text)
        {
            return provider.Search(DbContext, User, query, text);
        }
        
        #region Routed Methods
        //[Route("{entityTypeName}/search")]
        public ActionResult Search(string entityTypeName, string query, bool allowMultipleSelection = false, string text = "")
        {
            var provider = GetProvider(entityTypeName);
            var searchResults = GetSearchResults(provider, query, text);

            if (Request.HttpMethod == "GET")
            {
                var model = new SearchViewModel { Provider = provider, Results = searchResults };
                return View(model);
            }
            else
            {
                searchResults.AllowMultipleSelection = allowMultipleSelection;
                return View("Results", searchResults);
            }
        }

        //[Route("{entityTypeName}/search"), HttpPost]
        public ActionResult Results(string entityTypeName, string query, bool allowMultipleSelection = false, string text = "")
        {
            var provider = GetProvider(entityTypeName);
            var searchResults = GetSearchResults(provider, query, text);
            searchResults.AllowMultipleSelection = allowMultipleSelection;

            if (!allowMultipleSelection)
                return View(searchResults);
            else
                return View(searchResults);
        }
        #endregion
        
        #region Nested Types/Classes
        public class SearchViewModel
        {
            public ISearchProvider Provider { get; set; }
            public SearchResults Results { get; set; }
        } 
        #endregion
    }
}