namespace AftoRoboric;

public partial class GameOver : ContentPage
{
    int count = 0;

	public GameOver()
    {
        InitializeComponent();     
    }

      	 void BotaoYes(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}


       	 void BotaoNao(object sender,EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}

}    