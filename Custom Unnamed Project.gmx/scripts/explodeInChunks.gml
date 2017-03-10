Life = argument0
chunksToSpawn = argument1
bulletType = argument2
damage = argument3

hitBullet = instance_place(x,y, argument2)

if instance_exists(hitBullet)
{
    with hitBullet
    {   
        if (object_index = oBullet1 || object_index = oFlamethrower)  // messy af but basically only destroy it if its a certain bullet type
        instance_destroy()
    }
    
    Life = Life - argument3
    
    if Life <= 0 
    {
        for (i = 0; i < 10; i++)
        {
            Enemy2Chunk = instance_create(x,y, chunksToSpawn)
            Enemy2Chunk.direction = random(360)
            Enemy2Chunk.speed = random_range(500, 700)/room_speed
        }
        if (chunksToSpawn == oEnemy2DestroyedBits){  // if enemy2Dies play death sound
        audio_play_sound(aEnemy2Death, 1, 0)
        }
        instance_destroy()
    }
    
}
return Life
