using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace hobbyHub.Models
{
    public class Hobby
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
        public List<association> User_ { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; } = DateTime.Now;    
    }
}