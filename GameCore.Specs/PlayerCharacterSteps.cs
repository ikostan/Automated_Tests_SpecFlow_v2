using System;
using System.Linq;
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

        [Given(@"I have a damage resistance of (.*)")]
        public void GivenIHaveADamageResistanceOf(int resistance)
        {
            _player.DamageResistance = resistance;
        }

        [Given(@"I'm an (.*) race")]
        public void GivenIMAnElf(string character)
        {
            _player.Race = character;
        }

        [Given(@"I have the following attributes")]
        public void GivenIHaveTheFollowingAttributes(Table table)
        {
            //LINQ:
            var race = table.Rows.First(
                TableRow => TableRow["attribute"] == "Race")["value"];

            var resistance = int.Parse(table.Rows.First(
                TableRow => TableRow["attribute"] == "Resistance")["value"]);

            _player.Race = race;
            _player.DamageResistance = resistance;
        }

        [Then(@"My health now should be (.*), and my status (.*), and my resistance (.*)")]
        public void ThenMyHealthNowShouldBeAndMyStatus(int expectedHealth, bool status, int expectedResistance)
        {
            Assert.Equal(expectedHealth, _player.Health);
            Assert.Equal(status, _player.IsDead);
            Assert.Equal(expectedResistance, _player.DamageResistance);
        }

        [Then(@"I should be (.*) dead, expected health (.*) or less")]
        public void ThenIShouldBeDeadExpectedHealthOrLess(bool status, int expectedHealth)
        {
            Assert.True(expectedHealth >= _player.Health);
            Assert.Equal(status, _player.IsDead);
        }

        [Given(@"My character class is set to (.*)")]
        public void GivenMyCharacterClassIsSetToHealer(CharacterClass character)
        {
            _player.CharacterClass = character;
        }

        [When(@"Cast a healing spell")]
        public void WhenCastAHealingSpell()
        {
            _player.CastHealingSpell();
        }

    }
}
