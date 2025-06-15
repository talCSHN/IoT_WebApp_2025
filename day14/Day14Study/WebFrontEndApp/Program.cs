namespace WebFrontEndApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);  // ASP.NET Core 시작 빌더객체 생성
            // 빌더객체의 기능 : MVC패턴 설정, DB설정, 권한설정, API설정 등 웹앱의 전체 설정 담당

            // MVC패턴 설정
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // 빌더로 만든 app객체 설정
            app.UseStaticFiles();   // wwwroot 폴더의 정적리소스 사용하겠음

            app.UseRouting();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
