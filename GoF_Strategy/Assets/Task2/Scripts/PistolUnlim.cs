using UnityEngine;

public class PistolUnlim : Weapon
{
    private const int AMMO_PERSHOOT_PISTOL = 1;
    public PistolUnlim()
    {
        SetReloadBehavior(new NoNeedReloadingBehavior());
    }    

    public override void Shoot()
    {
        Debug.Log($"Pistol unlim: Shooting {AMMO_PERSHOOT_PISTOL} bullet");
    }    
}
