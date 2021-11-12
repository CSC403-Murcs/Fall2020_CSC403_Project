# Fall2020_CSC403_Project

## Features

**Animations and Music**
- Starting the game displays a loading screen.
- The welcome screen displays gif animations and plays music.

**Leaderboard**
- Fastest times are kept on a leaderboard which can be displayed from the welcome screen.

**Respawning**
- After defeating an enemy it will respawn, stronger than before.

**Boss Fight**
- After winning a certain amount of battles, you get to fight a boss to lock in your final time.

**Skills**
- Mr. Peanut has different skills which he can train to a higher level (Melee/Ranged/Magic).
- Higher levels equate to more damage dealt by a certain skill.

**Items**
- Enemies drop items which can be equipped to enhance skills.
- Item inventory can be opened with "i".

**Sneaking**
- Enemies have an awareness effect. Sneaking helps you get the jump on them.

## Controls
- Arrow Keys - Move
- i - Open Inventory
- k - Crouch
- j - Uncrouch

## Building

1. Clone.
2. Open .sln in Visual Studio 2019+.
3. Click Build -> Build Solution.
4. Output .exe and partnering .dll will be in `<ProjectPath>/Fall2020_CSC403_Project/Project/Fall2020_CSC403_Project/bin/Debug/`.
5. All resources will be packed into the .exe for portability.

## Known Bugs
- If the player stands where the enemy dies and the enemy respawns, The FrmBattle.cs Form continously opens.

## File Structure

### Fall2020_CSC403_Project
Forms and resources.

**FrmBattle.cs**
- methods
  - btnAttack_Click - *added* increases playerScore by 1 if enemy is defeated.

**FrmInventory.cs**

**FrmLevel.cs**
- methods 
  - tmrDisplayBoss_Tick - Checks every game tick if player reached score for boss to appear. if player wins, passes the final time to the VictoryScreen Form. If player loses then displays GameOver Form.
  - inGameScore_update_Tick - displays and updates player's current score.
- Properties
  - spawn - Boolean to see if boss is spawned
  - once - Boolean to only spawn boss once
  - fTime - Calculates final time
  
**GameInstructions.cs**
- methods
  - Confirm_click - Closes GameInstructions Form upon pressing button.
**GameOver.cs**
- methods
  - gameOver_click - Closes all forms upon pressing Quit Game button.
**IntroAnnimation.cs**

**WelcomeScreen.cs**

**VictoryScreen.cs**
- methods
  - displayTime_Tick - Retrieves the final time spent on the FrmLevel and displays it on VictoryScreen Form.
  - gameQuit_Click - When the gameQuit button is clicked it closes all Forms.
- properties
  t - TimeSpan variable that is set to the final time.

### MyGameLibrary
Library of character and item information.

**BattleCharacter.cs**
- class BattleCharacter
  - Properties
    - Health - Current health of the character. Wraps over Skill class object.
    - MaxHealth - Max health of the character. Wraps over Skill class object.
    - Skills - Dictionary of character Skill objects.
  - Methods
    - BattleCharacter - Skills are initialized to a default.
    - Damage - Damage character, die if necessary.
    - Heal - Heal character a certain amount.
    - FullyHeal - Fully heal character.
    - GetHealth - Get current character health.
    - AddSkill - Add a skill type to the Skills dictionary.
    - HighestSkillLevel - Get the highest skill level of character.
    - AttackStrength - Get the highest possible hit for a character's skill type.
    - SetSkill - Unused; sets a skill's level.
    - EquipmentBonus - Virtual, unused; get's the item bonus for a character's skill type.
    - Die - Virtual; Death mechanics.

**Character.cs**
- Properties
  - playerScore - Keeps track of score points earned after defeating a enemy.

**Collider.cs**
- Methods
  - noticeRadius - Get collider position's notice radius.
  - notices - Detects if this collider position notices a player.

**Defs.cs**
- Enums
  - EnemyType - Types of enemy classes.
  - AttackType - Types of attack methods.
- class Defs
  - Properties
    - SKILL_MELEE - "Melee"
    - SKILL_RANGED - "Ranged"
    - SKILL_MAGIC - "Magic"
    - SKILL_HP - "Health"
    - RESPAWN_TIME - 10.0
  - Methods
    - AttackTypeToString - static; converts AttackType enum into SKILL_* value.
- class Helpers
  - Properties
    - _r - Random number generator.
  - Methods
    - Random - Get pre-seeded random number.

**Enemy.cs**
- class Enemy
  - Properties
    - Respawner - Reference to enemy's respawner object.
  - Methods
    - Enemy - Set enemy type and randomize skills and max health.
    - Die - Die and handle respawner.

**Game.cs**
- *No new methods or properties added*

**Inventory.cs**
- TODO; Parsa

**Item.cs**
- TODO; Parsa

**NPC.cs**
- *No new methods or properties added*

**Player.cs**
- class Player
  - Properties
    - inventory - Player inventory object.
    - noticeThreshold - Player notice threshold.
  - Methods
    - addItemToInventory - Add an item to the player's inventory.
    - removeItemToInventory - Remove an item to the player's inventory.
    - EquipmentBonus - Virtual and unused; get's the item bonus for a character's skill type.
    - GainExperience - Gain experience in a certain skill.
    - useItemFromInventory - Use an item in the player's inventory.
    - sneak - Begin sneaking.

**Respawner.cs**
- class Respawner
  - Properties
    - RespawnTime - Delta time for detecting respawning.
    - Position - Position of the respawner.
    - Enemy - Enemy assigned to this respawner.
    - Collider - Collider for the respawner; *moved from Enemy class to here*.
    - PictureBox - PictureBox of the respawner.
    - Color - Color of the PictureBox.
    - IsActive - Detects if the respawner can be collided with.
  - Methods
    - Respawner - Initializes enemy and collider.
    - SetRespawn - Hide picture and disable collisions.
    - Respawn - Reenable picture visibility and collisions.
    - Update - Check and see if it is time to respawn enemy.
    - SetColor - Set enemy's picture color.

**Skill.cs**
- class Skill
  - Properties
    - Name - Name of the skill
    - Level - Current skill base level.
    - CurrentLevel - Currently set skill level.
    - MaxLevel - Maximum possible level of a skill (99).
    - Experience - Current experience this skill has.
    - MaxExperience - Experience needed to level up a skill to the next level.
    - Bonus - Item bonus.
  - Methods
    - Skill - Construct a skill object.
    - CalcExp - Static; calculates the experience needed to set for a required level.
    - AddExperience - Add experience to a skill, leveling up if necessary.
    - LevelUp - Level up a skill.
    - SetLevel - Manually set a skill's level.
    - SetCurrentLevel - set the current level of a skill, used for Health.

**Vector2.cs**
- *No new methods or properties added*

## Contributing
Please open a Pull Request with documented features.