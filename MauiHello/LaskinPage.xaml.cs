using System.Data;
using System.Runtime.Intrinsics.X86;

namespace MauiHello;

public partial class LaskinPage : ContentPage
{
	public LaskinPage()
	{
		InitializeComponent();
        
	}


    // T‰t‰ metodia kutsutaan silloin kun switch-case k‰sittelyss‰ havaitaan, ett‰
    // on painettu "=" -merkki‰.
    private void LaskeTulos()
    {
        try
        {
            string kaava = display_field.Text;

            // Lasketaan tulos kaavasta
            var table = new DataTable();
            var result = table.Compute(kaava, string.Empty);

            display_field.Text = result.ToString();
        }
        catch {

           DisplayAlert("Virhe", "Tyhjennet‰‰n kaava", "ok");
           display_field.Text = "";

        }
    }


    private void Button_Clicked(object sender, EventArgs e)
	{
        //  object sender on geneerinen ilmaisu ja koska tied‰mme kyseess‰ olevan buttonin voimme tehd‰
		// objektin tietotyypin muunnoksen eli cast:in buttoniksi.

        var button = sender as Button;
        //var button = (Button)sender; <--  vaihtoehtoinen syntaksi castin tekemiseen

        string btnText = button.Text;

        switch (btnText)
        {
            case "=":
                LaskeTulos();
                break;

            case "C":
                display_field.Text = "";
                break;

            default:
                display_field.Text += btnText;
                break;
        }
    }

}