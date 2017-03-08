Life = argument0
chunksToSpawn = argument1

hitBullet = instance_place(x,y,oBullet)

if instance_exists(hitBullet)
{
    with hitBullet
    {
        instance_destroy()
    }
    
    Life--
    
    if Life == 0 
    {
        for (i = 0; i < 10; i++)
        {
            Enemy2Chunk = instance_create(x,y, chunksToSpawn)
            Enemy2Chunk.direction = random(360)
            Enemy2Chunk.speed = random_range(500, 700)/room_speed
        }
        instance_destroy()
    }
    
}
return Life
