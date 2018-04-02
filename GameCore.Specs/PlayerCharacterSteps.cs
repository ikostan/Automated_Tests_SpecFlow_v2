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
        
        [When(@"I take 0 damage")]
        public void WhenITakeDamage()
        {
            _player.Hit(0);
        }
        
        [Then(@"My helth must remain 100")]
        public void ThenMyHelthMustRemain()
        {
            int expectedHealth = 100;
            Assert.Equal(expectedHealth, _player.Health);
        }
    }
}
