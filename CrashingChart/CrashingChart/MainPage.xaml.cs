namespace CrashingChart
{
    public partial class MainPage
    {
        public MainPage()
        {
            BindingContext = new MainViewModel();

            InitializeComponent();
        }
    }
}