using projeto_mobile_dono_posto_app.Views.Funcionarios;

namespace projeto_mobile_dono_posto_app.Views.Account;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class IURecuperarSenhaDonoPosto : ContentPage
{
	public IURecuperarSenhaDonoPosto()
	{
		InitializeComponent();
	}
    private void BtnVoltar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IULoginDonoPosto();

    }

    private  void Button_Recuperar_Senha_Clicked(object sender, EventArgs e)
    {
        preencheMensagemRecperarSenha();

        //     var LoginDonoPostoView = Navigation.NavigationStack.FirstOrDefault(p => p is IULoginDonoPosto);

        //if (LoginDonoPostoView != null)
        //{
        //    // A p�gina j� existe, verifica se � a p�gina atual antes de navegar para ela
        //    if (Navigation.NavigationStack.LastOrDefault() != LoginDonoPostoView)
        //    {
        //        await Navigation.PushAsync(LoginDonoPostoView);
        //    }
        //}
        //else
        //{
        //    // A p�gina n�o existe, cria uma nova inst�ncia e navega para ela
        //    await Navigation.PushAsync(new IULoginDonoPosto());
        //}
    }

    protected void preencheMensagemRecperarSenha()
    {

    }
    protected void preencheTelaRecperarSenha()
    {

    }
}