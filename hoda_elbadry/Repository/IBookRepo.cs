using hoda_elbadry.Dto;
using hoda_elbadry.Models;

namespace hoda_elbadry.Repository
{
    public interface IBookRepo
    {
        BookDto? getById(int id);
        List<BookDto> getAll();
        void Add(CreateBookDto dto);
        bool Update(BookDto dto);
        void Delete(int id);
    }
}
