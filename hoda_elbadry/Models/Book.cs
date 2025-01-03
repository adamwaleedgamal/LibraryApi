﻿namespace hoda_elbadry.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }  =String.Empty;
        public string Description { get; set; } = String.Empty;

        public IList<Author> Author { get; set; } = new List<Author>();
    }
}