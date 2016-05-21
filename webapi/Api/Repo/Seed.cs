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
            var books = new[]{
                new Book{
                    Autor="RR Martin",
                    Title="Game of thrones",
                    Description="LIbro sin usar",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://local/ima.jpg"
                },new Book{
                    Autor="JK Rowlin",
                    Title="Harry Potter",
                    Description="LIbro sin usar",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://local/ima.jpg"
                }
            };

            ConnectionManager.Database.DropCollection(ConnectionManager.BookCollection);

            var bookCollection = ConnectionManager.Database.GetCollection<Book>(ConnectionManager.BookCollection);
            bookCollection.InsertMany(books);

            var users = new[]{
                new Account{
                    Name="trueque",
                    User="trueque@gmail.com"
                },
                new Account{
                    Name="dev",
                    User="dev@gmail.com"
                }
            };

            ConnectionManager.Database.DropCollection(ConnectionManager.BookCollection);
            var accountCollection = ConnectionManager.Database.GetCollection<Account>(ConnectionManager.AccountCollection);
            accountCollection.InsertMany(users);
        }
    }
}