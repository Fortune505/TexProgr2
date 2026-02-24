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
            string inp = "Ћетит муха";
            string ojid = "Ћетит слон";
            string act = LogicBPLA.GetMena(inp);

            Assert.That(act, Is.EqualTo(ojid));
        }

        // new testi

        [Test]
        public void TestGetSkvNole()
        {
            double a = 0;
            double ojid = 0;

            double act = LogicBPLA.GetSKv(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetSKvOtri() {
            double a = -5;
            double ojid = 25;

            double act = LogicBPLA.GetSKv(a);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetSKrNole() {

            double r = 0;
            double ojid = 0;
            double act = LogicBPLA.GetSKr(r);

            Assert.That(act, Is.EqualTo(ojid));

        }

        [Test]
        public void TestGetSKrOtri()
        {

            double r = -5;
            double ojid = 78.5;
            double act = LogicBPLA.GetSKr(r);

            Assert.That(act, Is.EqualTo(ojid));

        }

        [Test]
        public void TestGetChNole() {
            double a = 5;
            int b = 0;
            double ojid = 0;
            double act = LogicBPLA.GetCh(a, b);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetChOtri()
        {
            double a = -5;
            int b = 5;
            double ojid = -25;
            double act = LogicBPLA.GetCh(a, b);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetMenaBezMux()
        {
            string inp = "Ћетит кто-то в две пашни";
            string ojid = "Ћетит кто-то в две пашни";
            string act = LogicBPLA.GetMena(inp);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetMenaNetu()
        {
            string inp = null;
            string ojid = "";
            string act = LogicBPLA.GetMena(inp);

            Assert.That(act, Is.EqualTo(ojid));
        }

        [Test]
        public void TestGetMenaMnooogaMux()
        {
            string inp = "муха, муха, муха, муха, комар!";
            string ojid = "слон, слон, слон, слон, комар!";
            string act = LogicBPLA.GetMena(inp);
                      
            Assert.That(act, Is.EqualTo(ojid));
        }
    }
}