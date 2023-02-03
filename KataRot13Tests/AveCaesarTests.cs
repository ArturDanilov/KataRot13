using KataRot13;

namespace KataRot13Tests
{
    public class AveCaesarTests
    {
        AveCaesar _aveCaesar = new AveCaesar();
        [SetUp]
        public void Setup()
        {
            _aveCaesar = new AveCaesar();
        }
        [TearDown]
        public void Teardown()
        {
            _aveCaesar = null;
        }

        [Test]
        public void Converter_Eingabe_H_ReturnU()
        {
            var actual = _aveCaesar.Converter("H");

            Assert.That(actual, Is.EqualTo("U"));
        }

        [Test]
        public void Converter_Eingabe_e_ReturnR()
        {
            var actual = _aveCaesar.Converter("e");

            Assert.That(actual, Is.EqualTo("R"));
        }

        [Test]
        public void Converter_Eingabe_l_ReturnY()
        {
            var actual = _aveCaesar.Converter("l");

            Assert.That(actual, Is.EqualTo("Y"));
        }

        [Test]
        public void Converter_Eingabe_o_ReturnB()
        {
            var actual = _aveCaesar.Converter("o");

            Assert.That(actual, Is.EqualTo("B"));
        }

        [Test]
        public void Converter_Eingabe_Hello_ReturnURYYB()
        {
            var actual = _aveCaesar.Converter("Hello");

            Assert.That(actual, Is.EqualTo("URYYB"));
        }

        [Test]
        public void Converter_Eingabe_Hello_World_ReturnURYYB_JBEYQ()
        {
            var actual = _aveCaesar.Converter("Hello World");

            Assert.That(actual, Is.EqualTo("URYYB JBEYQ"));
        }

        [Test]
        public void Converter_Eingabe_HelloCommaWorld_ReturnURYYBJ_comma_BEYQ()
        {
            var actual = _aveCaesar.Converter("Hello, World");

            Assert.That(actual, Is.EqualTo("URYYB, JBEYQ"));
        }

        [Test]
        public void Converter_Eingabe_HelloCommaWorldAZ_ReturnURYYBJ_comma_BEYQ_AZ()
        {
            var actual = _aveCaesar.Converter("Hello, World!");

            Assert.That(actual, Is.EqualTo("URYYB, JBEYQ!"));
        }

        [Test]
        public void Converter_Eingabe_Ö_ReturnOE()
        {
            var actual = _aveCaesar.Converter("Ö");

            Assert.That(actual, Is.EqualTo("BR"));
        }

        [Test]
        public void Converter_Eingabe_Ä_ReturnAE()
        {
            var actual = _aveCaesar.Converter("Ä");

            Assert.That(actual, Is.EqualTo("NR"));

        }

        [Test]
        public void Converter_Eingabe_ß_ReturnSS()
        {
            var actual = _aveCaesar.Converter("ß");

            Assert.That(actual, Is.EqualTo("FF"));
        }

        [Test]
        public void Converter_Eingabe_Ü_ReturnUE()
        {
            var actual = _aveCaesar.Converter("Ü");

            Assert.That(actual, Is.EqualTo("HR"));
        }

        [Test]
        public void Converter_Eingabe_HalöchenComaSüß_ReturnUE()
        {
            var actual = _aveCaesar.Converter("Hallöchen, Süß");

            Assert.That(actual, Is.EqualTo("UNYYBRPURA, FHRFF"));
        }
    }
}