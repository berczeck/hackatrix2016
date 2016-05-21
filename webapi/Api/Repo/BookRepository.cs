using Api.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repo
{
    public class ConnectionManager
    {
        public static IMongoClient Client;
        public static IMongoDatabase Database;

        public const string BookCollection = "books";

        static ConnectionManager()
        {
            Client = new MongoClient("mongodb://localhost:27017/");
            Database = Client.GetDatabase("Truqueando");
        }
    }
    public class BookRepository
    {
        public void Add(Book book)
        {
            var coleccion = ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
            coleccion.InsertOne(book);
        }

        public IEnumerable<Book> GetAll()
        {
            var coleccion = ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
            
            return coleccion.Find<Book>(Builders<Book>.Filter.Empty).ToList();
        }

        public IEnumerable<Book> FindByTerm(string term)
        {
            var coleccion = ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
            var builder = Builders<Book>.Filter;
            var filter = builder.Eq("x", 10) & builder.Lt("y", 20);
            return coleccion.Find<Book>(filter).ToList();
        }
    }
}