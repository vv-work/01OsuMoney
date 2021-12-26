using Assets.Scripts.Logic;
using NUnit.Framework;

namespace Logic.Tests
{
    public class Tests00OsuEntity
    {
        private IOsuEntity _osuEntity;
        private OsuFactory _osuFactory;

        [SetUp]
        public void Setup()
        {
            _osuFactory = new OsuFactory();
            _osuEntity = _osuFactory.CreateEntity();
        }

        [Test]
        public void Test00ClickOnTime()
        {
            
            var entity = _osuFactory.CreateEntity(); 
            entity.Click(0f);
        }
    }
}