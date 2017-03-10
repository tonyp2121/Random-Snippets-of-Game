//argument0 = object being tested if hit
//argument1 = firstHit
//argument2 = Invincibility

EnemyCollision1 = instance_place(x,y,argument0)

if instance_exists(EnemyCollision1)
{
    if argument1 == 0  //if you've never been hit before we give you an invincibility window and show youre damaged.
    {
        sprite_index = sPlayerDestroyed
        argument1++
        BitFiringSpeed = (random(200)+300)/room_speed
        newBit = instance_create(x,y, oPlayerDestroyBits)
        newBit.direction = random(360)
        newBit.image_angle = random(360)
        newBit.speed = BitFiringSpeed
        audio_play_sound(aExplosionFirstHit, 1, false)
        sprite_index = sPlayerInvincible
    }
    if argument2 == 0
    {
        Bits = 8
    
    n = 0
    for (n=0; n< Bits; n++)
    {
        BitFiringSpeed = (random(200)+300)/room_speed
        newBit = instance_create(x,y, oPlayerDestroyBits)
        newBit.direction = random(360)
        newBit.image_angle = random(360)
        newBit.speed = BitFiringSpeed
    }
        audio_play_sound(aExplosionDeath, 1, false)
        instance_create(view_wview[0]*.5 + view_xview[0], view_hview[0]*.5 + + view_yview[0], oGameOver)
        instance_destroy()
    }
}

return argument1
