﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Shared.DTO.Product
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        public IFormFile ImageFile { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
        public bool IsHot { get; set; }
    }
}
