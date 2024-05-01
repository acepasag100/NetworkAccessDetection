using NetworkAccessDetection.Service;

namespace NetworkAccessDetection
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private readonly IRickAndMortyService service;

        public MainPage(IRickAndMortyService service)
        {
            this.service = service;
            InitializeComponent();
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        private async void Connectivity_ConnectivityChanged(object? sender, ConnectivityChangedEventArgs e)
        {
            if(e.NetworkAccess == NetworkAccess.Internet)
            {
                HttpClient client = new HttpClient();
                string text = await client.GetStringAsync("https://animechan.xyz/api/random");
                string item = "";
            }
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;
            var data = await service.Obtainer();
            lvPerson.ItemsSource = data;
            loading.IsVisible = false;
        }
    }

}
