using Assets.Scripts.Logic;
using NUnit.Framework;

namespace Logic.Tests
{
    public class Tests
    {
        private ILogicManager _logicManger;

        [SetUp]
        public void Setup()
        {
            _logicManger = new LogicManager();
        }

        [Test]
        public void Test1()
        {
            bool init = _logicManger.IsInit;
            Assert.IsTrue(init);
        }
        [Test]
        public void Test2()
        {
            _logicManger.Destroy();
            Assert.Pass();
        }
    }
}