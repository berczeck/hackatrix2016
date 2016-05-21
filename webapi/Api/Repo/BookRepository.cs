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
        public const string AccountCollection = "accounts";

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

        public void AddComment(Comment comment)
        {
            var coleccion = ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
            
        }

        public void AddRanking(Ranking commrankingent)
        {

        }
        
        public IEnumerable<Book> GetAll()
        {
            var coleccion = ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
            return coleccion.Find<Book>(Builders<Book>.Filter.Eq("borrowed",false)).ToList();
        }

        public IEnumerable<Book> FindByTerm(string term)
        {
            var coleccion = ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
            var builder = Builders<Book>.Filter;
            var filter = (builder.Eq("author", term) | builder.Eq("genre", term) | builder.Eq("title", term)) & builder.Eq("borrowed", false);
            return coleccion.Find<Book>(filter).ToList();
        }
    }
}