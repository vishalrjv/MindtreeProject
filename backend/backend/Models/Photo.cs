using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("Photos")]
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("bookDetail")]
        public int BId { get; set; }
       
        public BookDetail bookDetail { get; set; }
    }
}