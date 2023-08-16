using UnityEngine;

public class Pistol : Weapon
{
    public override void Shoot()
    {
        if (_ammo <= 0)
        {
            Debug.Log("Pistol: bullets ran out");
            return;
        }
        _ammo--;
        Debug.Log("Pistol: Shooting 1 bullet");
    }

    public override void Reload()
    {
        _ammo = 10;
        Debug.Log("Pistol: Reloading");
    }
}
