using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json.Linq;

namespace ParserWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static HttpClient client = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        public async Task Init() {
            string net = "https://www.cbr-xml-daily.ru/daily_json.js";
            var response = await client.GetStringAsync(net);
            JObject json = JObject.Parse(response);
            var valute = json["Valute"];
           
        }
    }
}