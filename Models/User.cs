using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VioletArchive.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Username { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        [NotMapped]
        public List<int> Comments { get; set; }
        public int Karma { get; set; }
        


    }
}
