using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VioletArchive.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Message { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public int Votes { get; set; }
        public int ParentId { get; set; }

    }
}
