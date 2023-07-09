namespace projeto_mobile_dono_posto_app.Views.Account;
using Microsoft.Maui.Controls;

using Microsoft.Maui.Controls.Xaml;
using projeto_mobile_dono_posto_app.Views.Funcionarios;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class CadastroPostoView : ContentPage
{
	public CadastroPostoView()
	{
		InitializeComponent();
	}

    private void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new IUListaFuncionarios();
        //await Navigation.PushAsync(new IULoginDonoPosto());
        //var LoginDonoPostoView = Navigation.NavigationStack.FirstOrDefault(p => p is IULoginDonoPosto);

        //if (LoginDonoPostoView != null)
        //{
        //    // A página já existe, navega para ela
        //    await Navigation.PushAsync(LoginDonoPostoView);
        //}
        //else
        //{
        //    // A página não existe, cria uma nova instância e navega para ela
        //    await Navigation.PushAsync(new IULoginDonoPosto());
        //}

    }
    private void BtnVoltar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUCadastroDonoPosto();

    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        listView.IsVisible = !listView.IsVisible;
    }

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedItems = listView.ItemsSource.Cast<ItemLiquido>()
            .Where(item => item.IsSelected)
            .ToList();

        var selectedFruits = selectedItems.Select(item => item.Name).ToList();

        // Lógica para processar os itens selecionados
    }



}
public class ItemLiquido
{
    public string Name { get; set; }
    public string QtdLitro{ get; set; }
    public bool IsSelected { get; set; }

}


