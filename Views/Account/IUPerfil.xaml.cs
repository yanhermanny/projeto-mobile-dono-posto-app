using projeto_mobile_dono_posto_app.Views.Funcionarios;

namespace projeto_mobile_dono_posto_app.Views.Account;

public partial class IUPerfil : ContentPage
{
	public IUPerfil()
	{
		InitializeComponent();
	}
    private void Btn_Perfil_Navbar_Click(object sender, EventArgs args)
    {

    }
    private void Btn_Postos_Navbar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new EditarPostoview();

    }

    private void Btn_Funcionarios_Navbar_Click(object sender, EventArgs args)
    {

        App.Current.MainPage = new IUListaFuncionarios();

    }
    private void Btn_Dashboard_Click(object sender, EventArgs args)
    {

        App.Current.MainPage = new IUListaFuncionarios();

    }
    private void Btn_Editar_Click(object sender, EventArgs args)
    {

        App.Current.MainPage = new EditarDonoPostoview();

    }
    private void Btn_Redefinir_Click(object sender, EventArgs args)
    {

        App.Current.MainPage = new RedefinirSenhaLogadoView();

    }
    private void Btn_Sair_Click(object sender, EventArgs args)
    {

        App.Current.MainPage = new IULoginDonoPosto();


    }
}