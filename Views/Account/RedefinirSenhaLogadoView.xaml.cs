namespace projeto_mobile_dono_posto_app.Views.Account;

public partial class RedefinirSenhaLogadoView : ContentPage
{
	public RedefinirSenhaLogadoView()
	{
		InitializeComponent();
	}
    private void BtnVoltar_Click(object sender, EventArgs args)
    {
       App.Current.MainPage = new IUPerfil();

    }
}