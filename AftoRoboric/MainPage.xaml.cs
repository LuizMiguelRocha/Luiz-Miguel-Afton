namespace AftoRoboric;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void BotaoPrevia(object sender, EventArgs args)
	{
		framePrevia.IsVisible = true;
	}

	private void BotaoVoltarPrevia(object sender, EventArgs args)
	{
		framePrevia.IsVisible = false;
	}
}

