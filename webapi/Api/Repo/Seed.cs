using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repo
{
    public class Seed
    {
        public static void Init()
        {
            var libros = new []{
                new Book{
                    Autor="RR Martin",
                    Titulo="Game of thrones",
                    Description="LIbro sin usar",
                    Genre="Ficcion",
                    Identifier=Guid.NewGuid().ToString(),
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://local/ima.jpg"
                },new Book{
                    Autor="JK Rowlin",
                    Titulo="Harry Potter",
                    Description="LIbro sin usar",
                    Genre="Ficcion",
                    Identifier=Guid.NewGuid().ToString(),
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://local/ima.jpg"
                }
            };

            ConnectionManager.Database.DropCollection(ConnectionManager.BookCollection);
            
            var coleccion = ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
            coleccion.InsertMany(libros);
        }
    }
}