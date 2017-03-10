if y < 0 or y > room_height
{
    vspeed = -vspeed 
    if object_index == oBullet2
    {
        numberOfBounces--
        bounceNumChanged = 1
    }
}

if x < 0 or x > room_width
{
    hspeed = -hspeed 
    if object_index == oBullet2
    {
        numberOfBounces--
        bounceNumChanged = 1
    }
}


