using CapaNegocio;

namespace CapaNegocioTest
{
    [TestClass]
    public class UnitTest1
    {
        Credito credito = new Credito();

        [TestMethod]
        public void capacidadEndeudamiento50vecesMayor()
        {
            bool aprobado = credito.aceptarCredito(4321, 1, 25, 51);
            Assert.AreEqual(false,aprobado);
        }
        [TestMethod]
        public void menorDe25PuntajeMenor750()
        {
            bool aprobado = credito.aceptarCredito(1111, 1, 24, 50);
            Assert.AreEqual(false, aprobado);
        }
        [TestMethod]
        public void menorDe25PuntajeMayor750()
        {
            bool aprobado = credito.aceptarCredito(5678, 1, 24, 50);
            Assert.AreEqual(true, aprobado);
        }
        [TestMethod]
        public void mayorDe25Puntajemenor850()
        {
            bool aprobado = credito.aceptarCredito(9999, 1, 25, 50);
            Assert.AreEqual(false, aprobado);
        }
        [TestMethod]
        public void mayorDe25PuntajeMayor850()
        {
            bool aprobado = credito.aceptarCredito(1290, 1, 25, 50);
            Assert.AreEqual(true, aprobado);
        }
    }
}