using hoda_elbadry.Data;
using hoda_elbadry.Dto;
using hoda_elbadry.Models;
using Microsoft.EntityFrameworkCore;

namespace hoda_elbadry.Repository
{
    public class BookRepo : IBookRepo
    {
        private readonly AppDbContext _context;

        public BookRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Add(CreateBookDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                Description = dto.Description,
                Author = dto.Author.Select(x => new Author
                {
                    Id = x.Id,
                    Description = x.Description,
                    Name = x.Name,
                }).ToList()
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
        
        public List<BookDto> getAll()
        {
            return _context.Books.Include(x=>x.Author)
                .Select(x=>new BookDto
            {
                Id=x.Id,
                Title=x.Title,
                Description=x.Description,
                AuthorDtos = x.Author.Select(x=> new AuthorDto
                {
                    Id = x.Id,
                    Description=x.Description,
                    Name = x.Name, 
                }).ToList(),
            }).ToList();
        }

        public BookDto? getById(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return null;
            }
            return new BookDto
            {
                Id = book.Id,
                Description = book.Description,
                Title = book.Title,
                AuthorDtos = book.Author.Select(x=>new AuthorDto
                {
                    Id = x.Id,
                    Description = x.Description,
                    Name = x.Name,
                }).ToList(),
            };
        }

        public bool Update(BookDto dto)
        {
            var book = new Book
            {
                Id = dto.Id,
                Title = dto.Title,
                Description = dto.Description,
                Author = dto.AuthorDtos.Select(x=>new Author
                {
                    Id = x.Id,
                    Description = x.Description,
                    Name = x.Name,
                }).ToList(),
            };
            _context.Books.Update(book);
            _context.SaveChanges();
            return true;
        }
    }
}
