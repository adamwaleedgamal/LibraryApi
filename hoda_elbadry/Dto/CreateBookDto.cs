using hoda_elbadry.Models;

namespace hoda_elbadry.Dto
{
    public class CreateBookDto
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;

        public IList<Author> Author { get; set; } = new List<Author>();
    }
}
