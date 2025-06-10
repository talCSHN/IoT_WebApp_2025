using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;     // DB스키마 정의 클래스

namespace WebApiApp01.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]  // Not Null일 경우 nullable 타입 사용X
        [Column(TypeName = "VARCHAR(100)")] // 이거 사용 안하면 컬럼이 LONGTEXT로 생성됨
        public string Title { get; set; }

        [Required]  // Not Null일 경우 nullable 타입 사용X
        [Column(TypeName = "CHAR(8)")]
        public string TodoDate { get; set; }

        // boolean
        public bool IsComplete { get; set; }
    }
}
