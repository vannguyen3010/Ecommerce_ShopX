﻿using Microsoft.AspNetCore.Http;
using Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Banner
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }

        [NotMapped] // Sẽ ko lưu ảnh vào Db
        public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string? FileDescription { get; set; }
        public string FileExtension { get; set; }
        public long FileSizeInBytes { get; set; }
        public string FilePath { get; set; }
        [Required]
        public BannerPosition Position { get; set; }
    }
   
}
