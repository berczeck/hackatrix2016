using Api.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repo
{

    public class BookCommandRepository
    {
        public void Add(Book book)
        {
            var coleccion = ConnectionManager.GetBookCollection();
            coleccion.InsertOne(book);
        }

        public void AddComment(Comment comment)
        {
            var coleccion = ConnectionManager.GetBookCollection();

        }

        public void AddRanking(Ranking commrankingent)
        {
            var coleccion = ConnectionManager.GetBookCollection();
        }
    }
}