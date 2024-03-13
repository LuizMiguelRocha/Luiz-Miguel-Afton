namespace AftoRoboric;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void BotaoIniciar(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}

    private void BotaoSobre(object sender,EventArgs args)
	{
         frameSobre.IsVisible=true;
	}

	private void BoataoVoltarSobre(object sender,EventArgs args)
	{
		frameSobre.IsVisible = false;
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

