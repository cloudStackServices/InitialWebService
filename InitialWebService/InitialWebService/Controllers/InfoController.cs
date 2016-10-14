using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using InitialWebService.Models;

namespace InitialWebService.Controllers
{
    public class InfoController : ApiController
    {
        // GET api/info
        // public IEnumerable<string> Get()

        // www.klingerdev.com/Info/api/Info returns {"id":"1","content":"Hello World"}
        // local/api/Info returns {"id":"1","content":"Hello World"}

        public InitialWebServiceObject Get()
              {
                  var myModel = new InitialWebServiceObject();
                  myModel.id = "1";
                  myModel.content = "Hello World";

                  return myModel;
        //          // return new string[] { "value1", "value2" };
              }

        // GET api/info/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/info
        public string Post([FromBody]string value)
        {
            return "Hello POST World";
        }

        // PUT api/info/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/info/5
        public void Delete(int id)
        {
        }
    }
}
