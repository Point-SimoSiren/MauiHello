namespace MauiHello
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private async void btn_hello_Clicked(object sender, EventArgs e)
        {
            lbl_hello.Text = "Hello";

            await Task.WhenAny<bool>
                 (
                    btn_hello.RotateTo(360, 500),
                    lbl_hello.ScaleTo(2, 2000),
                    lbl_hello.TranslateTo(200, 500, 1000)
                );
            
                btn_hello.Rotation = 0;
        }
    }

}
