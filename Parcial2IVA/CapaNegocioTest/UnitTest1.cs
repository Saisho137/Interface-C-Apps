using CapaNegocio;

namespace CapaNegocioTest
{
    [TestClass]
    public class UnitTest1
    {
        Impuesto impuesto = new Impuesto();

        [TestMethod]
        public void Cafe()
        {
            double temp = impuesto.valorFinal("Café", 100);
            Assert.AreEqual(105,temp);
        }
        [TestMethod]
        public void Harina()
        {
            double temp = impuesto.valorFinal("Harina", 100);
            Assert.AreEqual(105, temp);
        }
        [TestMethod]
        public void Pastas()
        {
            double temp = impuesto.valorFinal("Pastas", 100);
            Assert.AreEqual(105, temp);
        }
        [TestMethod]
        public void Embutidos()
        {
            double temp = impuesto.valorFinal("Embutidos", 100);
            Assert.AreEqual(105, temp);
        }
        [TestMethod]
        public void Licores()
        {
            double temp = impuesto.valorFinal("Licores", 100);
            Assert.AreEqual(119, temp);
        }
        [TestMethod]
        public void Cereales()
        {
            double temp = impuesto.valorFinal("Cereales", 100);
            Assert.AreEqual(119, temp);
        }
        [TestMethod]
        public void Aceites()
        {
            double temp = impuesto.valorFinal("Aceites", 100);
            Assert.AreEqual(119, temp);
        }
        [TestMethod]
        public void Condimentos()
        {
            double temp = impuesto.valorFinal("Condimentos", 100);
            Assert.AreEqual(119, temp);
        }
        [TestMethod]
        public void Carne()
        {
            double temp = impuesto.valorFinal("Carne", 100);
            Assert.AreEqual(100, temp);
        }
        [TestMethod]
        public void Pescado()
        {
            double temp = impuesto.valorFinal("Pescado", 100);
            Assert.AreEqual(100, temp);
        }
        [TestMethod]
        public void Leche()
        {
            double temp = impuesto.valorFinal("Leche", 100);
            Assert.AreEqual(100, temp);
        }
        [TestMethod]
        public void Queso()
        {
            double temp = impuesto.valorFinal("Queso", 100);
            Assert.AreEqual(100, temp);
        }
    }
}