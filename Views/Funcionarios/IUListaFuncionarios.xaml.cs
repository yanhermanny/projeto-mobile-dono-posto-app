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
                new Funcionario { Nome = "João", NomePosto = "POSTO 1", EnderecoPosto = "RUA Tecnologia" , DtRequisicao = "Requisitado dia 13/05/2023 ás 16:45"},
                new Funcionario { Nome = "Maria", NomePosto = "POSTO 1", EnderecoPosto = "RUA Design", DtRequisicao = "Requisitado dia 13/05/2023 ás 16:45"},
                new Funcionario { Nome = "Pedro", NomePosto = "POSTO 1", EnderecoPosto = "RUA Gestão", DtRequisicao = "Requisitado dia 13/05/2023 ás 16:45" },
                new Funcionario { Nome = "Pedro", NomePosto = "POSTO 1", EnderecoPosto = "RUA Gestão",DtRequisicao = "Requisitado dia 13/05/2023 ás 16:45"},
                new Funcionario { Nome = "Pedro", NomePosto = "POSTO 1", EnderecoPosto = "RUA Gestão", DtRequisicao = "Requisitado dia 13/05/2023 ás 16:45" },
                new Funcionario { Nome = "Pedro", NomePosto = "POSTO 1", EnderecoPosto = "RUA Gestão", DtRequisicao = "Requisitado dia 13/05/2023 ás 16:45" }
            };

        lvFuncionarios.ItemsSource = funcionarios;

}
    private void Btn_Perfil_Navbar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUPerfil();

    }private void Btn_Postos_Navbar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IULoginDonoPosto();

    }private void Btn_Funcionarios_Navbar_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUListaFuncionarios();

    }
    private void BtnAprovarFuncionario_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUListaFuncionarios();

    }
    private void BtnRecusarFuncionario_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUListaFuncionarios();

    }
     private void BtnBloquearFuncionario_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUListaFuncionarios();

    }
     private void BtnDesbloquearFuncionario_Click(object sender, EventArgs args)
    {
        App.Current.MainPage = new IUListaFuncionarios();

    }

    private string selectedItem;

    public string SelectedItem
    {
        get => selectedItem;
        set
        {
            selectedItem = value;
            // Lógica adicional ao selecionar um item
        }
    }
    private void ExecuteSearch()
    {
        // Lógica de pesquisa aqui
    }
    public class Funcionario
    {
        public string Nome { get; set; }
        public string NomePosto { get; set; }
        public string EnderecoPosto { get; set; }
        public string DtRequisicao { get; set; }
    }
    private void OnSearchButtonPressed(object sender, EventArgs e)
    {
        var searchBar = (SearchBar)sender;
        var searchTerm = searchBar.Text;

        // Lógica de pesquisa aqui
    }
}