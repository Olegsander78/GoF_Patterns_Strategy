using UnityEngine;

public class NoNeedReloadingBehavior : IReloadBehavior
{
    public int Reload(int ammo)
    {
        Debug.Log("Weapon unlim: No need to reload");
        return ammo; 
    }
}
