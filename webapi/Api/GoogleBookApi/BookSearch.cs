using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using Api.Models;

namespace Api.GoogleBookApi
{
    public class BookSearch
    {
        private static string API_KEY = "AIzaSyBb0hm3_8Wbt5CU9Ns4j2wqgcN1q2_OoLI";
        private static string IMAGE_NOT_FOUND = "https://books.google.com.pe/googlebooks/images/no_cover_thumb.gif";

        public static BooksService service = new BooksService(new BaseClientService.Initializer
        {
            ApplicationName = "ISBNBookSearch",
            ApiKey = API_KEY,
        });

        public static async Task<Book> SearchByISBN(string isbn)
        {
            var result = await service.Volumes.List(string.Format("isbn:{0}", isbn)).ExecuteAsync();

            if (result != null && result.Items != null)
            {
                var item = result.Items.FirstOrDefault();
                                
                return ToBook(item);
            }
            return null;
        }

        private static Book ToBook(Volume volume)
        {
            Book book = new Book()
            {
                Title = volume.VolumeInfo.Title
            };

            if (volume.VolumeInfo.ImageLinks != null && volume.VolumeInfo.ImageLinks.Thumbnail != null)
            {
                book.ImageUrl = volume.VolumeInfo.ImageLinks.Thumbnail;
            }
            else
            {
                book.ImageUrl = IMAGE_NOT_FOUND;
            }

            return book;
        }
    }
}