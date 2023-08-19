using UnityEngine;

public class Pistol : Weapon
{
    public Pistol(int ammoCapacity, int ammoCurrent, int ammoPerShoot) : base(ammoCapacity, ammoCurrent, ammoPerShoot, reloadBehavior: new ReloadingBehaviour())
    {
    }

    public override void Shoot()
    {
        if (AmmoCurrent <= 0)
        {
            Debug.Log("Pistol: bullets ran out");
            return;
        }
        AmmoCurrent -= AmmoPerShoot;
        Debug.Log($"Pistol: Shooting {AmmoPerShoot} bullet");
    }
}
