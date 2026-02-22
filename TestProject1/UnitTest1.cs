using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void TestGetSKv1()
        {
            double a = 5;
            double ojid = 25;

            double act = LogicBPLA.GetSKv(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetSKr2()
        {
            double r = 10;
            double ojid = 314;
            double act = LogicBPLA.GetSKr(r);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetCh3()
        {
            double a = 5;
            int b = 3;
            double ojid = 15;
            double act = LogicBPLA.GetCh(a, b);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetMena()
        {
            string inp = "Летит муха";
            string ojid = "Летит слон";
            string act = LogicBPLA.GetMena(inp);

            Assert.That(act, Is.EqualTo(ojid));
        }
    }
}