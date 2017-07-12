//argument 0 == enemy touched
//argument 1 == bool about if it hit the enemy first that way it doesnt stay around
hitEnemy = argument1

enemyCollision = instance_place(x,y, argument0)

if (enemyCollision && hitEnemy == 0){
    vspeed = -vspeed 
    hspeed = -hspeed
    hitEnemy = 1
    numberOfBounces --
    bounceNumChanged = 1
}

if (!enemyCollision && hitEnemy == 1)
    hitEnemy = 0;
 
return hitEnemy
