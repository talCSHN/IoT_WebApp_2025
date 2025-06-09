using System.ComponentModel.DataAnnotations;

namespace WebApiApp02.Models
{
    public class Book
    {
        // Key
        [Key]
        public int Idx { get; set; }


        // 책 제목
        [Required]
        public string Names { get; set; }

        // 책 저자
        [Required]
        public string Author { get; set; }

        // 출판일
        [Required]
        public DateOnly ReleaseDate { get; set; }
    }
}
