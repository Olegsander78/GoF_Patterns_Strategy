using UnityEngine;

public class Shootgun : Weapon
{
    private const int AMMO_CAPACITY_SHOOTGUN = 12;
    private const int AMMO_PERSHOOT_SHOOTGUN = 3;

    public Shootgun(int ammo) : base(fullAmmo:AMMO_CAPACITY_SHOOTGUN, ammo, ammoPerShoot:AMMO_PERSHOOT_SHOOTGUN, reloadBehavior: new ReloadingBehaviour())
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
        Debug.Log($"Shootgun: Shooting {AMMO_PERSHOOT_SHOOTGUN} bullets in a row");
    }
}
