using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Api
{
    public class BookController : ApiController
    {
        public IHttpActionResult GetBooks()
        {
            return Ok("ok");
        }
    }
}
