using Assets.Scripts.Logic;
using NUnit.Framework;

namespace Logic.Tests
{
    public class Tests00OsuEntity
    {
        private OsuFactory _osuFactory;

        [SetUp]
        public void Setup()
        {
            _osuFactory = new OsuFactory();
            Osu.SetTimeFunc(()=>25.1f);
        }

        [Test]
        public void Test00ClickOnTime()
        {

            IOsuEntity entity = _osuFactory.CreateEntity(0,25.0f,1.0f,0.5f);
            entity.OnHit += (t) =>
            {
                if (t > 0.01f && t < 1.0f)
                {
                    Assert.Pass("We call onHit and value is in range");
                }
                else
                {
                    Assert.Fail($"value t = {t} and outside -1 ,1 range");
                }
            };
            entity.Click();
        }

        [Test]
        public void Test01TimeOut()
        {

            IOsuEntity entity = _osuFactory.CreateEntity(0,1.0f,0.5f);
            entity.OnHit += (t) =>
            {
                Assert.Fail("We invoke on hit but we are complitly out of range");
            };
            entity.OnTimeOut += () =>
            {
                Assert.Pass("We got to timeout");
            };
            entity.Update();

            try
            {
                entity.Click();
            }
            catch
            { 
                Assert.Pass();
            }


        }
    }
}