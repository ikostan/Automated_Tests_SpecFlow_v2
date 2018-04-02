Feature: PlayerCharacter
	In order to play the game
	As a humat character
	I want my character health to be correctly represented


Scenario Outline: Starting health is reduced when hit
	Given I'm a new _player
	When I take <damage> damage
	Then My health now should be <expectedHealth>, and my status <isDead>, and my resistance <expectedResistance>
	
	Examples:
	| damage | expectedHealth | isDead | expectedResistance |
	| 0      | 100            | false  | 0                  |
	| 40     | 60             | false  | 0                  |
	| 5      | 95             | false  | 0                  |
	| 1      | 99             | false  | 0                  |
	| 99     | 1              | false  | 0                  |


Scenario Outline: Taking too much damage results in player death
	Given I'm a new _player
	When I take <damage> damage
	Then I should be <isDead> dead, expected health <expectedHealth> or less
	
	Examples: 
	| damage | isDead | expectedHealth |
	| 100    | true   | 0              |


	Scenario: Elf race characters get additional 20 damage resistance
		Given I'm a new _player
			And I have a damage resistance of 10
			And I'm an Elf race
		When I take 40 damage
		Then My health now should be 90, and my status false, and my resistance 10