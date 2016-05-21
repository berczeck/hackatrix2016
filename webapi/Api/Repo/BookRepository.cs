using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repo
{
    public class BookRepository
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        static BookRepository()
        {
            _client = new MongoClient("mongodb://localhost:27017/");
            _database = _client.GetDatabase("book");
        }



    }
}