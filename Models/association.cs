using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace hobbyHub.Models
{
    public class association
    {
        [Key]
        public int id { get; set; }
        public string level { get; set; }
        [ForeignKey("User")]
        public int User_id { get; set; }
        public User User { get; set; }
        [ForeignKey("Hobby")]
        public int Hobby_id { get; set; }
        public Hobby Hobby { get; set; }
    }
}