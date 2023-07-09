using projeto_mobile_dono_posto_app.Views.Account;

namespace projeto_mobile_dono_posto_app;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new IULoginDonoPosto();
		
    }

  
}
