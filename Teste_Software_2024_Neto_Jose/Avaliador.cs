namespace Leilao
{
    public class Avaliador
    {
        public double MaiorLance { get; private set; } = double.MinValue;
        public double MenorLance { get; private set; } = double.MaxValue;

        public void AvaliarLances(Leilao leilao)
        {
            foreach (var lance in leilao.Lances)
            {
                AtualizaMaiorLance(lance);
                AtualizaMenorLance(lance);
            }
        }

        internal void AtualizaMenorLance(Lance lance)
        {
            if (lance.Valor < MenorLance)
            {
                MenorLance = lance.Valor;
            }
        }

        internal void AtualizaMaiorLance(Lance lance)
        {
            if (lance.Valor > MaiorLance)
            {
                MaiorLance = lance.Valor;
            }
        }
    }

}
