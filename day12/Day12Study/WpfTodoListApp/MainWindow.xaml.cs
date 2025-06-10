using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WpfTodoListApp.Models;

namespace WpfTodoListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        HttpClient client = new HttpClient();
        TodoItemsCollection todoItems = new TodoItemsCollection();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            var comboPairs = new List<KeyValuePair<string, int>> { 
                new KeyValuePair<string, int>("완료" , 1),
                new KeyValuePair<string, int>("미완료" , 0),
            };
            CboIsCompleted.ItemsSource = comboPairs;
            
            // RestAPI 호출 준비
            client.BaseAddress = new System.Uri("http://localhost:6200/");  // API 서버 URL
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // 데이터 가져오기
            GetDatas();
        }

        private async Task GetDatas()
        {
            // api/TodoItems GET 메서드 호출
            GrdTodoItems.ItemsSource = todoItems;

            try  // API 호출
            {
                // http://localhost:6200/api/TodoItems
                HttpResponseMessage? response = await client.GetAsync("/api/TodoItems");
                response.EnsureSuccessStatusCode(); // 상태코드 확인

                var items = await response.Content.ReadAsAsync<IEnumerable<TodoItem>>();
                todoItems.CopyFrom(items);  // ObservableCollection으로 형변환

                // 성공 메시지
                await this.ShowMessageAsync("API 호출", "Load Success");
            }
            catch (Exception ex)
            {
                // 예외 메시지
                await this.ShowMessageAsync("API 호출 에러", ex.Message);
            }
        }

        private async void BtnInsert_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                var todoItem = new TodoItem
                {
                    Id = 0, // Id는 테이블에서 Auto Increment
                    Title = TxtTitle.Text,
                    TodoDate = Convert.ToDateTime(DtpTodoDate.SelectedDate).ToString("yyyyMMdd"),
                    IsComplete = Convert.ToBoolean(CboIsCompleted.SelectedValue),
                };

                // 데이터 입력 확인
                //Debug.WriteLine(todoItem.Title);

                // POST 메서드 API 호출
                var response = await client.PostAsJsonAsync("/api/TodoItems", todoItem);
                response.EnsureSuccessStatusCode();

                GetDatas();

                InitControls();

            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("API 호출 에러", ex.Message);
            }
        }

        private async void GrdTodoItems_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            try
            {
                //await this.ShowMessageAsync("클릭", "클릭확인");
                var Id = (GrdTodoItems.SelectedItem as TodoItem)?.Id;
                if (Id == null)
                {
                    return;
                }
                // /api/TodoItems/{Id} GET 메서드 API 호출
                var response = await client.GetAsync($"/api/TodoItems/{Id}");
                response.EnsureSuccessStatusCode();

                var item = await response.Content.ReadAsAsync<TodoItem>();

                TxtId.Text = item.Id.ToString();
                TxtTitle.Text = item.Title.ToString();
                DtpTodoDate.SelectedDate = DateTime.Parse(item.TodoDate.Insert(4, "-").Insert(7, "-"));
                CboIsCompleted.SelectedValue = item.IsComplete;
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("API 호출 에러", ex.Message); 
            }
        }

        private async void BtnUpdate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                var todoItem = new TodoItem()
                {
                    Id = Convert.ToInt32(TxtId.Text),
                    Title = TxtTitle.Text,
                    TodoDate = Convert.ToDateTime(DtpTodoDate.SelectedDate).ToString("yyyyMMdd"),
                    IsComplete = Convert.ToBoolean(CboIsCompleted.SelectedValue),
                };
                var response = await client.PutAsJsonAsync($"/api/TodoItems/{todoItem.Id}", todoItem);
                response.EnsureSuccessStatusCode();

                GetDatas();
                InitControls();
            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("API 호출 에러", ex.Message);
            }
        }
        private void InitControls()
        {
            TxtId.Text = string.Empty;
            TxtTitle.Text = string.Empty;
            DtpTodoDate.Text = string.Empty;
            CboIsCompleted.Text = string.Empty;
        }

        private async void BtnDelete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                var Id = Convert.ToInt32(TxtId.Text);   // 삭제는 Id만 파라미터로 전송
                var response = await client.DeleteAsync($"/api/TodoItems/{Id}");
                response.EnsureSuccessStatusCode();

                GetDatas();
                
                InitControls();

            }
            catch (Exception ex)
            {
                await this.ShowMessageAsync("API 호출 에러", ex.Message);
            }
            
        }

    }
}