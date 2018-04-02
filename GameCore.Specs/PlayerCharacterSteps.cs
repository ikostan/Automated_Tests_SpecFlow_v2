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
        }

        //Parameterized method/test
        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            _player.Hit(damage);
        }
        
        [Then(@"My helth must remain (.*)")]
        public void ThenMyHelthMustRemain(int expectedHealth)
        {
            Assert.Equal(expectedHealth, _player.Health);
            Assert.False(_player.IsDead);
        }

        [Then(@"My health now should be (.*)")]
        public void ThenMyHealthNowShouldBe(int expectedHealth)
        {
            Assert.Equal(expectedHealth, _player.Health);
            Assert.False(_player.IsDead);
        }

        [Then(@"I should be dead, expected health (.*) or less")]
        public void ThenIShouldBeDead(int expectedHealth)
        {
            Assert.True(_player.Health <= expectedHealth);
            Assert.True(_player.IsDead);
        }
    }
}
