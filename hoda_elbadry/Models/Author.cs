﻿namespace hoda_elbadry.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IList<Book>? Books { get; set; }
    }
}