namespace projeto_mobile_dono_posto_app.Views.Account;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class IUCadastroDonoPosto : ContentPage
{
	public IUCadastroDonoPosto()
	{
		InitializeComponent();
	}
    private void BtnVoltar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IULoginDonoPosto();

    }
    private void Button_Continuar_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new CadastroPostoView();

    }
    //private async void Button_Continuar_Clicked(object sender, EventArgs e)
    //{
    //    var cadastroPostoView = Navigation.NavigationStack.FirstOrDefault(p => p is CadastroPostoView);

    //    if (cadastroPostoView != null)
    //    {
    //        // A página já existe, navega para ela
    //        await Navigation.PushAsync(cadastroPostoView);
    //    }
    //    else
    //    {
    //        // A página não existe, cria uma nova instância e navega para ela
    //        await Navigation.PushAsync(new CadastroPostoView());
    //    }
    //}
}