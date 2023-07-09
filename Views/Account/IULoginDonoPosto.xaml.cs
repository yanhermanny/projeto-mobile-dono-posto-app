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
        //var listaFuncionarioView = Navigation.NavigationStack.FirstOrDefault(p => p is IUListaFuncionarios);

        //if (listaFuncionarioView != null)
        //{
        //    // A página já existe, navega para ela
        //    await Navigation.PushAsync(listaFuncionarioView);
        //}
        //else
        //{
        //    // A página não existe, cria uma nova instância e navega para ela
        //    await Navigation.PushAsync(new IUListaFuncionarios());
        //}
    }
    private  void Button_Cadastro_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new IUCadastroDonoPosto();
        //var ocadastroDonPostoView = Navigation.NavigationStack.FirstOrDefault(p => p is IUCadastroDonoPosto);

        //if (ocadastroDonPostoView != null)
        //{
        //    // A página já existe, navega para ela
        //    await Navigation.PushAsync(ocadastroDonPostoView);
        //}
        //else
        //{
        //    // A página não existe, cria uma nova instância e navega para ela
        //    await Navigation.PushAsync(new IUCadastroDonoPosto());
        //}
    }
    private void Button_Recuperar_Senha_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new IURecuperarSenhaDonoPosto();
        //var RecuperarSenhaDonoPostoView = Navigation.NavigationStack.FirstOrDefault(p => p is IURecuperarSenhaDonoPosto);

        //if (RecuperarSenhaDonoPostoView != null)
        //{
        //    // A página já existe, navega para ela
        //    await Navigation.PushAsync(RecuperarSenhaDonoPostoView);
        //}
        //else
        //{
        //    // A página não existe, cria uma nova instância e navega para ela
        //    await Navigation.PushAsync(new IURecuperarSenhaDonoPosto());
        //}
    }
    private  void AbrirPagina(string pagina)
    {
        App.Current.MainPage = new IUCadastroDonoPosto();
        //    var cadastroDonoPostoView = Navigation.NavigationStack.FirstOrDefault(p => p is IUCadastroDonoPosto);

        //    if (cadastroDonoPostoView != null)
        //    {
        //        // A página já existe, navega para ela
        //        await Navigation.PushAsync(cadastroDonoPostoView);
        //    }
        //    else
        //    {
        //        // A página não existe, cria uma nova instância e navega para ela
        //        await Navigation.PushAsync(new IUCadastroDonoPosto());
        //    }

    }

}