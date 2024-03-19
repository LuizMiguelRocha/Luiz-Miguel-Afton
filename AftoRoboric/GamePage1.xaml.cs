namespace AftoRoboric;

public partial class GamePage1 : ContentPage
{
    int count = 0;

	public GamePage1()
    {
        InitializeComponent();     
    }

    	 void BotaoGeladeira(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GamePage2();
	}

      	 void BotaoArmario(object sender,EventArgs args)
	{
		Application.Current.MainPage = new Armario();
	}
    
}    