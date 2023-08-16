using UnityEngine;

public class Shootgun : Weapon
{
    public override void Shoot()
    {
        if (_ammo <= 0)
        {
            Debug.Log("Shootgun: bullets ran out");
            return;
        }
        _ammo -= 3;
        Debug.Log("Shootgun: Shooting 3 bullets in a row");
    }

    public override void Reload()
    {
        _ammo = 12;
        Debug.Log("Shootgun: Reloading");
    }
}
