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
        if (EntryEmail.IsVisible == true)
        {
            App.Current.MainPage = new IULoginDonoPosto();
        }
        else
        {
            preencheTelaRecperarSenha();
        }
        

    }

    private  void Button_Recuperar_Senha_Clicked(object sender, EventArgs e)
    {
        preencheMensagemRecperarSenha();

        //     var LoginDonoPostoView = Navigation.NavigationStack.FirstOrDefault(p => p is IULoginDonoPosto);

        //if (LoginDonoPostoView != null)
        //{
        //    // A página já existe, verifica se é a página atual antes de navegar para ela
        //    if (Navigation.NavigationStack.LastOrDefault() != LoginDonoPostoView)
        //    {
        //        await Navigation.PushAsync(LoginDonoPostoView);
        //    }
        //}
        //else
        //{
        //    // A página não existe, cria uma nova instância e navega para ela
        //    await Navigation.PushAsync(new IULoginDonoPosto());
        //}
    }

    protected void preencheMensagemRecperarSenha()
    {
        lblMsgDigiteEmail.Text = "Uma mensagem foi enviada para gabriel@gmail.com";
        EntryEmail.IsVisible = false;
        btnRecuperar.IsVisible = false;
    }
    protected void preencheTelaRecperarSenha()
    {
        lblMsgDigiteEmail.Text = "Digite seu email";

        EntryEmail.IsVisible = true;
        btnRecuperar.IsVisible = true;
    }
}