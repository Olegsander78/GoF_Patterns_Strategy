using UnityEngine;

public class Pistol : Weapon
{
    private const int AMMO_CAPACITY_PISTOL = 10;
    private const int AMMO_PERSHOOT_PISTOL = 1;
    public Pistol(int ammo) : base(fullAmmo:AMMO_CAPACITY_PISTOL, ammo, ammoPerShoot:AMMO_PERSHOOT_PISTOL, reloadBehavior: new ReloadingBehaviour())
    {
    }

    public override void Shoot()
    {
        if (Ammo <= 0)
        {
            Debug.Log("Pistol: bullets ran out");
            return;
        }
        Ammo -= AMMO_PERSHOOT_PISTOL;
        Debug.Log($"Pistol: Shooting {AMMO_PERSHOOT_PISTOL} bullet");
    }
}
