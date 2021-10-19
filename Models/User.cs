using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace hobbyHub.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters long!")]
        public string firstName { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters long!")]
        public string lastName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Must be at least 3 characters!")]
        [MaxLength(15, ErrorMessage = "Must be smaller than 15 characters!")]
        public string username { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*?[0-9])(?=.*?[A-Z])(?=.*?[^A-za-z0-9]).{8,}$", ErrorMessage = "Must be 8 characters, have an upper case, lower case, and a special character!")]
        public string password { get; set; }
        public List<association> activities_ { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;
        [NotMapped]
        [Compare("password", ErrorMessage = "Must be the same password!")]
        [DataType(DataType.Password)]
        public string confirm { get; set; }
    }
}