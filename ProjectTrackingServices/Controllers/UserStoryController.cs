using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTrackingServices.Controllers
{
    public class UserStoryController : ApiController
    {
        // GET api/userstory
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/userstory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/userstory
        public void Post([FromBody]string value)
        {
        }

        // PUT api/userstory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/userstory/5
        public void Delete(int id)
        {
        }
    }
}
