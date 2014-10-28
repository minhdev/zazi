using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace zazi.Models
{
    public class NoteEntry
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "you have no name??")]
        public string Name { get; set; }
    }
}