using projeto_mobile_dono_posto_app.Views.Funcionarios;
using System.Windows.Input;

namespace projeto_mobile_dono_posto_app.Views.Account;

public partial class IULoginDonoPosto : ContentPage
{
    public ICommand AbrirPaginaCommand { get; }

    public IULoginDonoPosto()
	{
		InitializeComponent();
        AbrirPaginaCommand = new Command<string>(AbrirPagina);
    }
    private void Button_Login_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new IUListaFuncionarios();
    }
    private void AbrirPagina(string pagina)
    { 
        App.Current.MainPage = new IUCadastroDonoPosto();

    }

}