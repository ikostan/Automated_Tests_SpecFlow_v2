using System;
using TechTalk.SpecFlow;
using Xunit;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter _player;

        [Given(@"I'm a new _player")]
        public void GivenIMANewPlayer()
        {
            _player = new PlayerCharacter();
            //_player.Race = "";
        }

        //Parameterized method/test
        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            //int damage = 0;
            _player.Hit(damage);
        }

        //[When(@"I take 0 damage")]
        //public void WhenITake0Damage()
        //{
        //    int damage = 0;
        //    _player.Hit(damage);
        //}
        
        [Then(@"My helth must remain 100")]
        public void ThenMyHelthMustRemain()
        {
            int expectedHealth = 100;
            Assert.Equal(expectedHealth, _player.Health);
            Assert.False(_player.IsDead);
        }

        //[When(@"I take 40 damage")]
        //public void WhenITake60Damage()
        //{
        //    int damage = 40;
        //    _player.Hit(damage);
        //}

        [Then(@"My health now should be 60")]
        public void ThenMyHealthNowShouldBe()
        {
            int expectedHealth = 60;
            Assert.Equal(expectedHealth, _player.Health);
            Assert.False(_player.IsDead);
        }

        //[When(@"I take 100 damage")]
        //public void WhenITake100Damage()
        //{
        //    int damage = 100;
        //    _player.Hit(damage);
        //}

        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            int expectedHealth = 0;
            Assert.True(_player.Health <= expectedHealth);
            Assert.True(_player.IsDead);
        }
    }
}
