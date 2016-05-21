using Api.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repo
{
    public class ConnectionManager
    {
        private static IMongoDatabase Database;

        public const string BookCollection = "books";
        public const string AccountCollection = "accounts";

        static ConnectionManager()
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            Database = client.GetDatabase("Truqueando");
        }

        public static IMongoCollection<Book> GetBookCollection()
        {
            return ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
        }

        public static IMongoCollection<Account> GetAccountCollection()
        {
            return ConnectionManager.Database.GetCollection<Account>(ConnectionManager.AccountCollection);
        }

        public static void DropCollection(string name)
        {
            ConnectionManager.Database.DropCollection(name);
        }
    }
}