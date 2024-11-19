using hoda_elbadry.Models;

namespace hoda_elbadry.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public IList<AuthorDto> AuthorDtos { get; set; } = new List<AuthorDto>();
    }
}
