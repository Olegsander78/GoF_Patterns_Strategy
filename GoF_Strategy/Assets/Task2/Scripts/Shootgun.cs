using UnityEngine;

public class Shootgun : Weapon
{
    public Shootgun(int ammoCapacity, int ammoCurrent,int ammoPerShoot) : base(ammoCapacity, ammoCurrent, ammoPerShoot, reloadBehavior: new ReloadingBehaviour())
    {
    }

    public override void Shoot()
    {
        if (AmmoCurrent <= 0)
        {
            Debug.Log("Shootgun: bullets ran out");
            return;
        }
        AmmoCurrent -= AmmoPerShoot;
        Debug.Log($"Shootgun: Shooting {AmmoPerShoot} bullets in a row");
    }
}
