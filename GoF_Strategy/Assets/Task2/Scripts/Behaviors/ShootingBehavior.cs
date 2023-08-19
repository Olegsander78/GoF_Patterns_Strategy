using UnityEngine;

public class ShootingBehavior : IShootBehavior
{
    public void Shoot()
    {
        Debug.Log("Weapon: Shoot");
    }
}