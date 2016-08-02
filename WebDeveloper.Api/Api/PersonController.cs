using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebDeveloper.Api.Api
{
    [RoutePrefix("person")]
    public class PersonController : ApiController
    {
        [HttpGet]
        public IHttpActionResult TestGet()
        {
            return Ok("Ok get");
        }

        [HttpPost]
        public IHttpActionResult TestPost()
        {
            return Ok("Ok post");
        }

        [HttpPut]
        public IHttpActionResult TestPut()
        {
            return Ok("Ok put");
        }

        [HttpDelete]
        public IHttpActionResult TestDelete()
        {
            return Ok("Ok delete");
        }
    }
}
