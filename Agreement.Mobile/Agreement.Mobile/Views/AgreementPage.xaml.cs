using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Agreement.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgreementPage : ContentPage
    {
        private const string Url = "https://192.168.1.4:44395/api/Get"; //TODO: Inidicar la IP Local.
        private readonly HttpClient _client = new HttpClient();
        private ObservableCollection<ViewModels.Agreement> _agreements;

        public AgreementPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            string content = _client.GetStringAsync(Url).GetAwaiter().GetResult();

            List<ViewModels.Agreement> lstAgreements = JsonConvert.DeserializeObject<List<ViewModels.Agreement>>(content);
            _agreements = new ObservableCollection<ViewModels.Agreement>(lstAgreements);

            lstViewAgreements.ItemsSource = _agreements;

            base.OnAppearing();
        }
    }
}