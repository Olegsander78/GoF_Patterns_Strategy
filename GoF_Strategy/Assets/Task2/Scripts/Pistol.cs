using UnityEngine;

public class Pistol : Weapon
{
    private const int AMMO_CAPACITY_PISTOL = 10;
    private const int AMMO_PERSHOOT_PISTOL = 1;
    public Pistol(int ammo, int ammoPerShoot) : base(ammo, ammoPerShoot)
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
        Debug.Log("Pistol: Shooting 1 bullet");
    }

    public override void Reload()
    {
        Ammo = AMMO_CAPACITY_PISTOL;
        Debug.Log("Pistol: Reloading");
    }
}
