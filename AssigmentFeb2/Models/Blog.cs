using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AssigmentFeb2.Models
{
        [Table("Post")]
    public class Blog
    {
        [Key]
        public int Id {  get; set; }
        public string Titile { get; set; }
        public string Content { get; set; }
        public DateTime PublicatiobDate { get; set; }
        public string Author { get; set; }
    }
}