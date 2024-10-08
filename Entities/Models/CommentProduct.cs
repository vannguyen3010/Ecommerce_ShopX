﻿using Entities.Identity;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class CommentProduct
    {
        public Guid Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; } 
        [Required]
        public Guid ProductId { get; set; }
        public string UserName { get; set; }
        public Product Product { get; set; }
        public string ProductName { get; set; }
        [Required]
        [StringLength(1000)]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
