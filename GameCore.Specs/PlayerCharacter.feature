Feature: PlayerCharacter
	In order to play the game
	As a humat character
	I want my character health to be correctly represented


Scenario Outline: Starting health is reduced when hit
	Given I'm a new _player
	When I take <damage> damage
	Then My health now should be <expectedHealth>, and my status <isDead>
	
	Examples:
	| damage | expectedHealth | isDead |
	| 0      | 100            | false  |
	| 40     | 60             | false  |
	| 5      | 95             | false  |
	| 1      | 99             | false  |
	| 99     | 1              | false  |


Scenario Outline: Taking too much damage results in player death
	Given I'm a new _player
	When I take <damage> damage
	Then I should be <isDead> dead, expected health <expectedHealth> or less
	
	Examples: 
	| damage | isDead | expectedHealth |
	| 100    | true   | 0              |