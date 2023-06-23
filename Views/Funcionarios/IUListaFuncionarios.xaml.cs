using projeto_mobile_dono_posto_app.Views.Account;
using System.Windows.Input;

namespace projeto_mobile_dono_posto_app.Views.Funcionarios;

public partial class IUListaFuncionarios : ContentPage
{
    public ICommand SearchCommand { get; set; }

    public IUListaFuncionarios()
	{
		InitializeComponent();
	
        List<Funcionario> funcionarios = new List<Funcionario>()
            {
                new Funcionario { Nome = "Jo�o", NomePosto = "POSTO 1", EnderecoPosto = "RUA Tecnologia" },
                new Funcionario { Nome = "Maria", NomePosto = "POSTO 1", EnderecoPosto = "RUA Design" },
                new Funcionario { Nome = "Pedro", NomePosto = "POSTO 1", EnderecoPosto = "RUA Gest�o" },
                new Funcionario { Nome = "Pedro", NomePosto = "POSTO 1", EnderecoPosto = "RUA Gest�o" },
                new Funcionario { Nome = "Pedro", NomePosto = "POSTO 1", EnderecoPosto = "RUA Gest�o" },
                new Funcionario { Nome = "Pedro", NomePosto = "POSTO 1", EnderecoPosto = "RUA Gest�o" }
            };

        lvFuncionarios.ItemsSource = funcionarios;

}
    private void Btn_Perfil_Navbar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUPerfil();

    }
    private string selectedItem;

    public string SelectedItem
    {
        get => selectedItem;
        set
        {
            selectedItem = value;
            // L�gica adicional ao selecionar um item
        }
    }
    private void ExecuteSearch()
    {
        // L�gica de pesquisa aqui
    }
    public class Funcionario
{
    public string Nome { get; set; }
    public string NomePosto { get; set; }
    public string EnderecoPosto { get; set; }
}
    private void OnSearchButtonPressed(object sender, EventArgs e)
    {
        var searchBar = (SearchBar)sender;
        var searchTerm = searchBar.Text;

        // L�gica de pesquisa aqui
    }
}