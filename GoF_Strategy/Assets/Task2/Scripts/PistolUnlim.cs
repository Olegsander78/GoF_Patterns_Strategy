using UnityEngine;

public class PistolUnlim : Weapon
{
    public override void Shoot()
    {
        Debug.Log("Pistol unlim: Shooting 1 bullet");
    }

    public override void Reload()
    {
        Debug.Log("Pistol unlim: No need to reload");
    }
}
