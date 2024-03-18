namespace AftoRoboric;

public partial class GamePage : ContentPage
{
    int count = 0;

	public GamePage()
    {
        InitializeComponent();     
    }


    	 void BotaoGamePage1(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GamePage1();
	}
    
}
    