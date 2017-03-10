//argument0 == bullethit

hitBullet = instance_place(x,y,argument0)

if instance_exists(hitBullet)
{
    with hitBullet
    {
        if (argument0 == oBullet){
            instance_destroy()}
    }
    
    image_xscale = image_xscale - .2
    image_yscale = image_xscale
    
    if image_xscale <= 0
    {
        //instance_create(random(view_wview[0]) + view_xview[0],  random(view_hview[0]) + view_yview[0], oEnemy1)
        // Originally was random(room_width) and random(room_height) but changed it so it spawned in the view.
        //instance_create(random(view_wview[0]) + view_xview[0],  random(view_hview[0]) + view_yview[0], oEnemy1)
        // The previous code was to respawn an enemy immediately after being destroyed
        audio_play_sound(aEnemy1Death, 1, 0)
        instance_destroy()
        
    }
    
}
