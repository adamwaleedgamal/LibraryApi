﻿using hoda_elbadry.Models;

namespace hoda_elbadry.Dto
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
