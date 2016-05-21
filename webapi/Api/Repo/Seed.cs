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
                    Title="Game of thrones I" ,
                    Description="Deseo comprar uno nuevo",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://files.juegodetronosepub.webnode.es/200000002-8d0528ef98/juegodetronos.jpg"
                },new Book{
                    Autor="JK Rowlin",
                    Title="Harry Potter",
                    Description="No me gusto el libro",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://image.casadellibro.com/a/l/t0/96/9788415480396.jpg"
                },new Book{
                    Autor="RR Martin",
                    Title="Game of thronres II",
                    Description="Ya lo termine de leer",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="https://images-na.ssl-images-amazon.com/images/I/51GdKSRSuPL.jpg"
                },new Book{
                    Autor="RR Martin",
                    Title="Game of thronres III",
                    Description="Quiero intercambiarlo por uno de Harry Potter",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://ecx.images-amazon.com/images/I/51ewdvP7pJL._SY344_BO1,204,203,200_.jpg"
                },new Book{
                    Autor="RR Martin",
                    Title="Game of thronres IV",
                    Description="No me gusto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://vignette2.wikia.nocookie.net/divergente/images/b/b5/Portada_de_Divergente.jpg"
                },new Book{
                    Autor="RR Martin",
                    Title="Game of thronres V",
                    Description="Excelente",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://www.quelibroleo.com/images/libros/libro_1362100102.jpg"
                },new Book{
                    Autor="EL James",
                    Title="50 sombras de grey I",
                    Description="Excelente",
                    Genre="Drama",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://www.eldinamo.cl/wp-content/uploads/2015/04/Harry.jpg"
                },new Book{
                    Autor="EL James",
                    Title="50 sombras de grey II",
                    Description="No me gusto",
                    Genre="Drama",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://salamandra.info/sites/default/files/books/images/hires/hp_y_el_prisionero_de_azkaban.jpg"
                },new Book{
                    Autor="EL James",
                    Title="50 sombras de grey III",
                    Description="No lo puedo tener en mi poder",
                    Genre="Drama",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://arcdn02.mundotkm.com/2015/06/124.jpg"
                },new Book{
                    Autor="RR Tolkien",
                    Title="El señor de los anillos",
                    Description="Excelente",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://ecx.images-amazon.com/images/I/51slbpKPmFL._AC_UL320_SR210,320_.jpg"
                },new Book{
                    Autor="RR Tolkien",
                    Title="El señor de los anillos II",
                    Description="No me gusto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://ecx.images-amazon.com/images/I/51UdKQyH6jL._SX327_BO1,204,203,200_.jpg"
                },new Book{
                    Autor="RR Tolkien",
                    Title="El señor de los anillos III",
                    Description="Quiero leer otos temas relacionados",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://www.jkrowling.com/uploads/images/large/es_ES-timeline-image-harry-potter-y-la-orden-del-fenix-1333556948.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Harry Potter I",
                    Description="Quiero leer el siguiente",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://i.blogs.es/0d9ebb/chica-gasolina/original.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Harry Potter II",
                    Description="Quiero leer el siguiente",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://www.quelibroleo.com/images/libros/libro_1362100102.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Harry Potter III",
                    Description="Quiero leer el siguiente",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://arcdn02.mundotkm.com/2015/06/124.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Harry Potter IV",
                    Description="No me gusto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://i.blogs.es/0d9ebb/chica-gasolina/original.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Harry Potter V",
                    Description="Me encanto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://arcdn02.mundotkm.com/2015/06/124.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Juegos del hambre I",
                    Description="Me encanto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://2.bp.blogspot.com/-FvhUPKOZqlM/UaemzEyv6bI/AAAAAAAAAKE/ldbuFBHg9Jc/s1600/sinsajo9.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Juegos del hambre II",
                    Description="Me encanto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://www.quelibroleo.com/images/libros/libro_1362100102.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Juegos del hambre III",
                    Description="Me encanto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://www.quelibroleo.com/images/libros/libro_1362100102.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Divergente I",
                    Description="Me encanto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://www.quelibroleo.com/images/libros/libro_1362100102.jpg"
                },new Book{
                    Autor="JK Rolling",
                    Title="Divergente II",
                    Description="Me encanto",
                    Genre="Ficcion",
                    Isbn    ="123213-123123-123",
                    ImageUrl="http://ecx.images-amazon.com/images/I/51ewdvP7pJL._SY344_BO1,204,203,200_.jpg"
                }
            };

            ConnectionManager.DropCollection(ConnectionManager.BookCollection);

            var bookCollection = ConnectionManager.GetBookCollection();
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

            ConnectionManager.DropCollection(ConnectionManager.AccountCollection);
            var accountCollection = ConnectionManager.GetAccountCollection();
            accountCollection.InsertMany(users);
        }
    }
}