﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required, MinLength(3, ErrorMessage = "Name must contain at least 50 characters")]
        public string Name { get; set; }
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        [Required]
        public Dept? Department { get; set; }
    }
}
