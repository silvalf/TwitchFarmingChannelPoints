namespace TwitchFarmingChannelPoints.Models
{
    public static class PointsRule
    {
        public static TableDisplay AssistirPorCincoMinutos
        {
            get
            {
                return new TableDisplay("Assitir por  minutos", 10);
            }
        }

        public static TableDisplay ReivindiqueBonusEspeciais
        {
            get
            {
                return new TableDisplay("Reivindique bônus especiais", 50);
            }
        }

        public static TableDisplay ParticiparDeUmaRaid
        {
            get
            {
                return new TableDisplay("Participar de uma Raid", 250);
            }
        }

        public static TableDisplay SigaEsteCanal
        {
            get
            {
                return new TableDisplay("Siga este canal", 300);
            }
        }

        public static TableDisplay PrimeiroCheerDoMes
        {
            get
            {
                return new TableDisplay("1º Cheer do mês", 350);
            }
        }

        public static TableDisplay PrimeiroPresenteComInscricaoDoMes
        {
            get
            {
                return new TableDisplay("1º Presentear com inscrição do mês", 500);
            }
        }

        public static TableDisplay CrieUmaSequenciaDeVisualizacoes
        {
            get
            {
                return new TableDisplay("Crie uma sequência de visualizações", 450);
            }
        }

    }

    public class TableDisplay
    {
        public string Title { get; set; }
        public double Points { get; set; }
        public TableDisplay()
        {
        }
        public TableDisplay(string title, double points)
        {
            this.Title = title;
            this.Points = points;
        }
    }

    public static class Cheer
    {
        public static TableDisplay CheerUm = new TableDisplay("Inscrito no grupo 1", 1.2);
        public static TableDisplay CheerDois = new TableDisplay("Inscrito no grupo 2", 1.4);
        public static TableDisplay CheerTres = new TableDisplay("Inscrito no grupo 3", 2.0);
    }
}
