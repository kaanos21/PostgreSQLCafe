﻿using PostgreSQLCafe.Entities;

namespace PostgreSQLCafe.Dto.ProductDto
{
    public class ResultProductWithCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int? CategoryId { get; set; }
        public bool Status { get; set; }
    }
}
