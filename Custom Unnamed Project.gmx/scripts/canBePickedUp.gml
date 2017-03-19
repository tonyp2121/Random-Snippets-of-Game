if (instance_exists(instance_place(x,y,oPlayer)))
{
    owner = oPlayer.id
    owner.weapon[owner.weaponCount] = self.id
    owner.weaponIndex = owner.weaponCount
    owner.weaponCount++
}
