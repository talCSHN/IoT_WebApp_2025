namespace WebFrontEndApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);  // ASP.NET Core ���� ������ü ����
            // ������ü�� ��� : MVC���� ����, DB����, ���Ѽ���, API���� �� ������ ��ü ���� ���

            // MVC���� ����
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // ������ ���� app��ü ����
            app.UseStaticFiles();   // wwwroot ������ �������ҽ� ����ϰ���

            app.UseRouting();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
