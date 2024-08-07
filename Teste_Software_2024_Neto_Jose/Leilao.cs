namespace Leilao
{
    public class Leilao
    {
        public List<Lance> Lances { get; private set; }

        public Leilao()
        {
            Lances = new List<Lance>();
        }

        public void RecebeLance(string nomeDoUsuario, double valor)
        {
            Lances.Add(new Lance(nomeDoUsuario, valor));
        }
    }

}
