namespace Leilao
{
    public class Lance(string nomeDoUsuario, double valor)
    {
        public string NomeDoUsuario { get; private set; } = nomeDoUsuario;
        public double Valor { get; private set; } = valor;
    }

}
