﻿using System.ComponentModel.DataAnnotations;


namespace _1911065522_PhungXuanDoan_BigSchool.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}