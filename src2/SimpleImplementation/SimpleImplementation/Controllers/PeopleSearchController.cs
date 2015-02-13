using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleImplementationModel.Queries;
using SimpleImplementationModel.ViewModels;

namespace SimpleImplementation.Controllers
{
    public class PeopleSearchController : ApiController
    {
        private readonly GetPeopleByFirstNameQuery _byFirstNameQuery;

        public PeopleSearchController(GetPeopleByFirstNameQuery byFirstNameQuery)
        {
            _byFirstNameQuery = byFirstNameQuery;
        }

        // GET: api/PeopleSearch/?firstname=foo
        public IEnumerable<PeopleListItem> Get(string firstName)
        {
            return _byFirstNameQuery.Execute(firstName);
        }
    }
}
