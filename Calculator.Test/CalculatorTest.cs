using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator sut;

        /* Luodaan olio testattavasta luokasta
         * Käytettävissä kaikissa testeissä */
        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new Calculator();
        }

        /* Testaa yhteenlaskun tuloksen */
        [Test]
        public void ShouldAddTwoNumbers()
        {
            int expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        /* Testaa kertolaskun tuloksen */
        [Test]
        public void ShouldMulTwoNumbers()
        {
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

        // Esimerkki kuinka yksittäisen testin voi jättää tekemättä
        [Test]
        [Ignore("Syy miksi ignorattiin")]
        public void ShouldNotMulTwoNumbers()
        {
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        // Asetaan testattavan luokan oliolle arvo null testien päätteeksi
        [OneTimeTearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }
}