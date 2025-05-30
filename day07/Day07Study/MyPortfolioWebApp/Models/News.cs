using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolioWebApp.Models
{
    // 실제 DB의 News 테이블로 만들어짐
    public class News
    {
        [Key] // Id == Primary Key
        [DisplayName("번호")]
        public int Id { get; set; }

        [DisplayName("작성자")]
        public string Writer { get; set; }

        [Required] // Not Null
        [DisplayName("뉴스제목")]
        public string Title { get; set; }

        [DisplayName("뉴스내용")]
        public string Description { get; set; }

        [DisplayName("작성일")]
        [DisplayFormat(DataFormatString = "{0:yyyy년 MM월 dd일}", ApplyFormatInEditMode = true)]
        public DateTime PostDate { get; set; }

        [DisplayName("조회수")]
        public int ReadCount { get; set; }
    }
}
