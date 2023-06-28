using projeto_mobile_dono_posto_app.Views.Funcionarios;

namespace projeto_mobile_dono_posto_app.Views.Account;

public partial class IURecuperarSenhaDonoPosto : ContentPage
{
	public IURecuperarSenhaDonoPosto()
	{
		InitializeComponent();
	}
   

         private void Button_Recuperar_Senha_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new IULoginDonoPosto();
    }
}