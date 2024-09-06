﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO.CommentProduct
{
    public class CreateCommentProductDto
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public Guid ProductId { get; set; } // ID sản phẩm được comment
        [Required]
        public string Content { get; set; } // Nội dung comment
        public string UserName { get; set; } // Tên người dùng đăng comment
        public int Rating { get; set; }
    }
    public class CommentProductDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Guid ProductId { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
