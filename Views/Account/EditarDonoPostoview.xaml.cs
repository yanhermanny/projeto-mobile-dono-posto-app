namespace projeto_mobile_dono_posto_app.Views.Account;

public partial class EditarDonoPostoview : ContentPage
{
	public EditarDonoPostoview()
	{
		InitializeComponent();
	}
    private void Button_Continuar_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new IUPerfil();

    }
    private void BtnVoltar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUPerfil();

    }
}
