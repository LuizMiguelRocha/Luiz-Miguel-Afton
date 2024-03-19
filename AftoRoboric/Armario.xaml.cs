namespace AftoRoboric;

public partial class Armario : ContentPage
{
    int count = 0;

	public Armario()
    {
        InitializeComponent();     
    }

        	 void BotaoA(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GamePage2();
	}
}    