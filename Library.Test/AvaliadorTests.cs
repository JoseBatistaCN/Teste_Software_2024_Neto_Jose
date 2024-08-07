namespace Leilao.Test
{
    [TestClass]
    public class AvaliadorTest
    {
        [TestMethod]
        public void TestAvaliarLances_DeveAtualizarMaiorEMenorLance()
        {
            // Arrange
            Leilao leilao = new Leilao();
            leilao.Lances.Add(new Lance("João", 100));
            leilao.Lances.Add(new Lance("Maria", 200));
            leilao.Lances.Add(new Lance("José", 150));

            Avaliador avaliador = new Avaliador();

            // Act
            avaliador.AvaliarLances(leilao);

            // Assert
            Assert.AreEqual(200, avaliador.MaiorLance);
            Assert.AreEqual(100, avaliador.MenorLance);
        }

        [TestMethod]
        public void TestAtualizaMenorLance_DeveAtualizarMenorLance()
        {
            // Arrange
            Avaliador avaliador = new Avaliador();
            Lance lance1 = new Lance("João", 100);
            Lance lance2 = new Lance("Maria", 200);

            // Act
            avaliador.AtualizaMenorLance(lance1);
            avaliador.AtualizaMenorLance(lance2);

            // Assert
            Assert.AreEqual(100, avaliador.MenorLance);
        }

        [TestMethod]
        public void TestAtualizaMaiorLance_DeveAtualizarMaiorLance()
        {
            // Arrange
            Avaliador avaliador = new Avaliador();
            Lance lance1 = new Lance("João", 100);
            Lance lance2 = new Lance("Maria", 200);

            // Act
            avaliador.AtualizaMaiorLance(lance1);
            avaliador.AtualizaMaiorLance(lance2);

            // Assert
            Assert.AreEqual(200, avaliador.MaiorLance);
        }
    }
}