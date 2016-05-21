using Akka.Actor;
using Api.Models;
using Api.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Actors
{
    public class BookActor : ReceiveActor
    {
        private readonly BookCommandRepository repo;

        public BookActor()
        {
            Receive<AddComment>(x => repo.AddComment(x.Comment));
            Receive<AddRanking>(x => repo.AddRanking(x.Ranking));
            Receive<AddBook>(x => repo.Add(x.Book));
        }        
    }

    public class AddComment { public Comment Comment { get; set; } }
    public class AddRanking { public Ranking Ranking { get; set; } }
    public class AddBook { public Book Book { get; set; } }
}