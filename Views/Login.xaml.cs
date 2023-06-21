namespace projeto_mobile_dono_posto_app.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Login_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new DonoAdd();
    }
}