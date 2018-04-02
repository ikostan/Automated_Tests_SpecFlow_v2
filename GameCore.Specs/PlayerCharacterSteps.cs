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
        public void GivenIMANew_Player()
        {
            _player = new PlayerCharacter();
        }
        
        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            _player.Hit(damage);
        }
        
        [Then(@"My health now should be (.*), and my status (.*)")]
        public void ThenMyHealthNowShouldBeAndMyStatus(int expectedHealth, bool status)
        {
            Assert.Equal(expectedHealth, _player.Health);
            Assert.Equal(status, _player.IsDead);
        }

        [Then(@"I should be (.*) dead, expected health (.*) or less")]
        public void ThenIShouldBeDeadExpectedHealthOrLess(bool status, int expectedHealth)
        {
            Assert.True(expectedHealth >= _player.Health);
            Assert.Equal(status, _player.IsDead);
        }
    }
}
