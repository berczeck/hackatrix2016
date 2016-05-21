using Api.Actors;
using Api.Models;
using Api.Repo;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        private readonly BookQueryRepository repo;

        public BooksController()
        {
            repo = new BookQueryRepository();
        }

        [Route("all")]
        public IEnumerable<Book> GetAll()
        {
            return repo.GetAll();
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
            ContextManager.SendMessage(new AddBook { Book = book });
            return Ok();
        }

        [Route("comment")]
        public IHttpActionResult Post(Comment comment)
        {
            ContextManager.SendMessage(new AddComment { Comment = comment });
            return Ok();
        }

        [Route("rank")]
        public IHttpActionResult Post(Ranking ranking)
        {
            ContextManager.SendMessage(new AddRanking { Ranking = ranking });
            return Ok();
        }

        [Route("find")]
        public Book GetByISBN(string isbn)
        {
            return  GoogleBookApi.BookSearch.SearchByISBN(isbn);
        }
    }

}
