using UnityEngine;

public class PistolUnlim : Weapon
{
    public PistolUnlim(int ammoPerShoot)
    {
        AmmoPerShoot = ammoPerShoot;
        SetReloadBehavior(new NoNeedReloadingBehavior());
    }    

    public override void Shoot()
    {
        Debug.Log($"Pistol unlim: Shooting {AmmoPerShoot} bullet");
    }    
}
