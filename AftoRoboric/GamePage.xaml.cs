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

   historia.Add(new HistoryStep()
    {
        Id=1,
        Texto="Você na sua geladeira e você na sabe se você toma um café normalmente como todo dia ou se você toma um copo de suco",
        TemResposta=true,
        TextoDaResposta01="Tomar café",
        TextoDaResposta02="Tomar um copo de suco",
        TextoDaResposta03="",
        IdLevelResposta01=2,
        IdLevelResposta02=3,
        IdLevelResposta03=1,
    }
    );

    historia.Add(new HistoryStep()
    {
        Id=2,
        Texto="Você pega uma xicara e toma um pouco de café com bolacha",
        TemResposta=false,
    });

    historia.Add(new HistoryStep()
    {
        Id=3,
        Texto="Você pega um copo de suco e come um pouco de bolacha",
        TemResposta=false,
    });     
    }


   void PreencherPagina()
   {
    labelTexto.Text = HistoryStepAtual.Texto;

    if (HistoryStepAtual.HeroIsDead)
        frameGameOver.IsVisible = true;
    else
        frameGameOver.IsVisible = false;

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
      
    else
    {
        BotaoProximo.IsVisible = true;
        Resposta1.IsVisible = false;
        Resposta2.IsVisible = false;
        Resposta3.IsVisible = false;
    }
   }


}
    