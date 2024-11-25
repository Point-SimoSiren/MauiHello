namespace MauiHello;

public partial class Lights : ContentPage
{
	public Lights()
	{
		InitializeComponent();

		olohuone_slider.Minimum = 0;
        olohuone_slider.Maximum = 100;

    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Huom", "Kytkimen arvoa muutettu", "ok");
    }
}