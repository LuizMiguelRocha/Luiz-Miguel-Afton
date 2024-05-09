namespace AftoRoboric;

public partial class GamePage2 : ContentPage
{
    int count = 0;

	public GamePage2()
    {
        InitializeComponent();     
    }

       	 void Comer(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GamePage3();
	}
}    