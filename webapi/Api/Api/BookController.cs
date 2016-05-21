using Api.Models;
using Api.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Api
{
    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        private readonly BookRepository repo;

        [Route("reset")]
        public IHttpActionResult Get()
        {
            Seed.Init();
            return Ok("OK");
        }

        [Route("reset")]
        public IHttpActionResult Get()
        {
            Seed.Init();
            return Ok("OK");

        }
        [Route("")]
        public IHttpActionResult Get(string term)
        {
            return Ok(term);
        }

        [Route("{id:int}")]
        public string Get(int id)
        {
            return "OK";
        }

        [Route("")]
        public IHttpActionResult Post(Book book)
        {
            return Ok("OK");
        }
    }

}
