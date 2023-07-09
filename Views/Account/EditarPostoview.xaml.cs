using projeto_mobile_dono_posto_app.Views.Funcionarios;
using projeto_mobile_dono_posto_app.Views.Postos;

namespace projeto_mobile_dono_posto_app.Views.Account;

public partial class EditarPostoview : ContentPage
{
	public EditarPostoview()
	{
		InitializeComponent();
	}
    private void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        
        

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
    private void Btn_Perfil_Navbar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUPerfil();

    }
    private void Btn_Postos_Navbar_Click(object sender, EventArgs args)
    {

    }

    private void Btn_Funcionarios_Navbar_Click(object sender, EventArgs args)
    {

        App.Current.MainPage = new IUListaFuncionarios();


    }

}