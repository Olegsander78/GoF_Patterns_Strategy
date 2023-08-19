using UnityEngine;

public class ReloadingBehaviour : IReloadBehavior
{
    public int Reload(int ammo)
    {
        Debug.Log("Weapon: Reloading");
        return ammo;
    }
}
