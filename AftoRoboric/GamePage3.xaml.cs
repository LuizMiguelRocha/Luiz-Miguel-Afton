namespace AftoRoboric;

public partial class GamePage3 : ContentPage
{
    int count = 0;

	public GamePage3()
    {
        InitializeComponent();     
    }

         	 void BottanNao(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GameOver();
	}

         	 void BotaoAtenter(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GamePage4();
	}
} 