using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTrackingServices.Controllers
{
    public class UserTasksController : ApiController
    {
        // GET api/usertasks
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/usertasks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/usertasks
        public void Post([FromBody]string value)
        {
        }

        // PUT api/usertasks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/usertasks/5
        public void Delete(int id)
        {
        }
    }
}
