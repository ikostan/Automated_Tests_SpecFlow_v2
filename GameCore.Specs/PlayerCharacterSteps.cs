using System;
using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        PlayerCharacter player;

        [Given(@"I'm a new player")]
        public void GivenIMANewPlayer()
        {
            player = new PlayerCharacter();
        }
        
        [When(@"I take 0 damage")]
        public void WhenITakeDamage()
        {
            player.Hit(0);
        }
        
        [Then(@"My helth must remain 100")]
        public void ThenMyHelthMustRemain()
        {
            //player.Health;
        }
    }
}
