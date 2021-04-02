# Astromania
Unity project file


###############################################################################

Asteroid : Object that moves freely in screen space
Enemy: Object that moves towards the objective
Player: spaceship
Objective: Earth

###############################################################################



##Player
	##.player moves around freely
	##.collide with enemies to destroy it

##Enemy
	##Enemy type 1
		##.moves around randomly
		##.can collide with objective
		##.players can collide to destroy enemy
	##Enemy type 2
		##.moves directly to the objective
		##.faster and smaller
		##.increased points
##Objective
	##.Player protects objective
	##.static objective
	##.3 health
	##.enemy will collide with objective cause to loose health




*******Mechanics*******

##.Player movement
##.Enemy type 1 movement
##.Enemy type 2 movement
.objective health
.score
.highscore
.UI
.main menu



*******Art*******

##.Player sprite
	##.Tron disk like spaceship with player inside
.Enemy 1 sprite
	.Asteroid large
.Enemy 2 sprite
	.Smaller asteroid
##.Background sprite
##.Objective sprite
.UI elements
	.health bar
	.Score
.Main menu buttons
	.Play
	.Quit


*******Scenes*******

.Main menu
	.Play button
	.Exit
	.animated background 
	.Game name
.Game scene
.Game Over scene
	.Retry
	.Exit
	.Highscore display
