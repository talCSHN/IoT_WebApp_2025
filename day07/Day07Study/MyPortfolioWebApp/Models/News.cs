using System.ComponentModel.DataAnnotations;

namespace MyPortfolioWebApp.Models
{
    // 실제 DB의 News 테이블로 만들어짐
    public class News
    {
        [Key] // Id == Primary Key
        public int Id { get; set; }
        public string Writer { get; set; }

        [Required] // Not Null
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public int ReadCount { get; set; }
    }
}
