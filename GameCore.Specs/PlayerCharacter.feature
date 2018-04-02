Feature: PlayerCharacter
	In order to play the game
	As a humat character
	I want my character health to be correctly represented

Scenario: Taking no damage when hit doesn't affect health
	Given I'm a new _player
	When I take 0 damage
	Then My helth must remain 100 

Scenario: Starting health is reduced when hit
	Given I'm a new _player
	When I take 40 damage
	Then My health now should be 60
