using UnityEngine;

public class Shootgun : Weapon
{
    private const int AMMO_CAPACITY_SHOOTGUN = 12;
    private const int AMMO_PERSHOOT_SHOOTGUN = 3;

    public Shootgun(int ammo, int ammoPerShoot) : base(ammo, ammoPerShoot)
    {
    }

    public override void Shoot()
    {
        if (Ammo <= 0)
        {
            Debug.Log("Shootgun: bullets ran out");
            return;
        }
        Ammo -= AMMO_PERSHOOT_SHOOTGUN;
        Debug.Log("Shootgun: Shooting 3 bullets in a row");
    }

    public override void Reload()
    {
        Ammo = AMMO_CAPACITY_SHOOTGUN;
        Debug.Log("Shootgun: Reloading");
    }
}
