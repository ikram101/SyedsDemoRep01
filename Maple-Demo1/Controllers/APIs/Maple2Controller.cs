using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Maple_Demo1.Controllers.APIs
{
    public class Maple2Controller : ApiController
    {
        // GET: api/Maple2
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Maple2/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Maple2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Maple2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Maple2/5
        public void Delete(int id)
        {
        }
    }
}
