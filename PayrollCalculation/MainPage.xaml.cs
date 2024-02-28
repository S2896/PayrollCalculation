namespace PayrollCalculation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NormalClassRegistration_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NormalClassRegistrationPage());
        }

        private async void Calendar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calendar_ClickedPage());
        }

        private async void Salary_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Salary_ClickedPage());
        }
    }
}
