using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using LibrarySystem;
using LibrarySystem.Models;

namespace LibrarySystem.Controllers
{
    public class BooksAPIController : ApiController
    {
        private library_system db = new library_system();
 
        // GET: api/BooksAPI
        public IQueryable<BookViewModel> GetBooks()
        { 
            var bookData= db.Books.Select(g => new BookViewModel()
            {
                AuthorId = g.AuthorId,  
                Description = g.Description,    
                Id = g.Id,
                MainCategoryId=g.MainCategoryId,
                SubCategoryId=g.SubCategoryId,  
                Title= g.Title,
                MainCategory = g.Category.CategoryName,
                SubCategory = g.SubCategory.SubCategory1
            });

            return bookData;
        }

        // GET: api/BooksAPI/5
        [ResponseType(typeof(Book))]
        public async Task<IHttpActionResult> GetBook(int id)
        { 
            Book book = await db.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            var bookData = new BookViewModel()
            {
                AuthorId = book.AuthorId,
                Description = book.Description,
                Id = book.Id,
                MainCategoryId = book.MainCategoryId,
                SubCategoryId = book.SubCategoryId,
                Title = book.Title,
                MainCategory = book.Category.CategoryName,
                SubCategory = book.SubCategory.SubCategory1
            };
             
            return Ok(bookData);
        } 

        private bool BookExists(int id)
        {
            return db.Books.Count(e => e.Id == id) > 0;
        }
    }
}