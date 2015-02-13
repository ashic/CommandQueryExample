using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleImplementationModel.Queries;

namespace SimpleImplementation.Controllers
{
    public class PersonRegistrationController : ApiController
    {
        private readonly RegisterPersonQuery _registerPersonQuery;

        public PersonRegistrationController(RegisterPersonQuery registerPersonQuery)
        {
            _registerPersonQuery = registerPersonQuery;
        }

        // POST: api/PersonRegistration
        public void Post([FromBody]string firstname, [FromBody]string lastName)
        {
            _registerPersonQuery.Execute(firstname, lastName);
            //not really doing status codes, etc. but would be done as usual.
        }
    }
}
