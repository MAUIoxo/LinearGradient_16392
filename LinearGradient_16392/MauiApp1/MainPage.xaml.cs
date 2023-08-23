namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (height > 0)
            {
                BackgroundImage.HeightRequest = height * 0.7;
            }
        }
    }
}