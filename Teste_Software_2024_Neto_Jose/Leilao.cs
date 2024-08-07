namespace Leilao
{
    public class Leilao
    {
        public IList<Lance> Lances { get; private set; }

        public Leilao()
        {
            Lances = [];
        }

        public void RecebeLance(string nomeDoUsuario, double valor)
        {
            Lances.Add(new Lance(nomeDoUsuario, valor));
        }
    }

}
