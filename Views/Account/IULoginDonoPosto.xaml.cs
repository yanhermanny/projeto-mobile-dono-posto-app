using projeto_mobile_dono_posto_app.Views.Funcionarios;

namespace projeto_mobile_dono_posto_app.Views.Account;

public partial class IULoginDonoPosto : ContentPage
{
	public IULoginDonoPosto()
	{
		InitializeComponent();
	}
    private void Button_Login_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new IUListaFuncionarios();
    }
}