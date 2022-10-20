﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Movie
    {
        [Key]       
           
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Title { get; set; } = string.Empty;

            [DataType(DataType.Date)]
            
        public DateTime ReleaseDate { get; set; }
        [StringLength(20)]
        public string? Genre { get; set; }
        [Range(0,20)]
        public decimal Price { get; set; } = 0;
        
    }
}
