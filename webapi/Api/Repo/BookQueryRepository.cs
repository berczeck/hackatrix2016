using Api.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repo
{
    public class BookQueryRepository
    {         
        public IEnumerable<Book> GetAll()
        {
            var coleccion = ConnectionManager.GetBookCollection();
            return coleccion.Find<Book>(Builders<Book>.Filter.Eq("borrowed",false)).ToList();
        }

        public IEnumerable<Book> FindByTerm(string term)
        {
            var coleccion = ConnectionManager.GetBookCollection();
            var builder = Builders<Book>.Filter;
            var filter = (builder.Eq("author", term) | builder.Eq("genre", term) | builder.Eq("title", term)) & builder.Eq("borrowed", false);
            return coleccion.Find<Book>(filter).ToList();
        }
    }
}