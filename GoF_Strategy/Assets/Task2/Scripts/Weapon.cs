public abstract class Weapon
{
    protected int _ammo;
    public void SetAmmo(int ammo)
    {
        _ammo = ammo;
    }

    //Template method
    public void UseWeapon()
    {
        Shoot();

        if (_ammo <= 0)
            Reload();
    }

    public abstract void Shoot();
    public abstract void Reload();

}
