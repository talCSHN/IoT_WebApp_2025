using Microsoft.EntityFrameworkCore;

namespace WebApiApp01.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        // 테이블 연결
        // 타입보다 뒤 객체변수명과 테이블명이 동일해야함
        // MySQL에 TodoItems 이름으로 테이블 생성되고 연결
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
