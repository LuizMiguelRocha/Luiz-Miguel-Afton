namespace AftoRoboric;

public partial class GamePage : ContentPage
{
  

  List<HistoryStep> historia = new List<HistoryStep>();
  HistoryStep HistoryStepAtual;

  

	public GamePage()
    {
        InitializeComponent();

     historia.Add(new HistoryStep()
   {
    Id= 0,
    Texto = "Você acorda de manhã maio cansado poos o caso que você esta tentando resolver não avança",
    TemResposta=false,
   });     
    }

   void PreencherPagina()
   {
    labelTexto.Text = HistoryStepAtual.Texto;

    if (HistoryStepAtual.HeroIsDead)
        frameGamerOver.IsVisible = true;
    else
        frameGamerOver.IsVisible = false;

    if (HistoryStepAtual.TemResposta)
    {
        BotaoProximo.IsVisible = false;
        Resposta1.IsVisible = true;
        Resposta2.IsVisible = true;
        Resposta3.IsVisible = true;
        Resposta1.Text = HistoryStepAtual.TextoDaResposta01;
        Resposta2.Text = HistoryStepAtual.TextoDaResposta02;
        Resposta3.Text = HistoryStepAtual.TextoDaResposta03;
    }
      
   } 
}
    