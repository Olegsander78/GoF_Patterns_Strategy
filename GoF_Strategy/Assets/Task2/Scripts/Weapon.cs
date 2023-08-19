public abstract class Weapon
{
    public int Ammo { get; protected set; }
    public int FullAmmo { get; protected set; }
    protected int AmmoPerShoot;

    protected IReloadBehavior _reloadBehavior;

    protected Weapon()
    {
    }
    protected Weapon(int fullAmmo, int ammo, int ammoPerShoot, IReloadBehavior reloadBehavior)
    {
        FullAmmo = fullAmmo;
        Ammo = ammo;
        AmmoPerShoot = ammoPerShoot;
        _reloadBehavior = reloadBehavior;
    }
    public abstract void Shoot();
    
    public void SetReloadBehavior(IReloadBehavior reloadBehavior)
    {
        _reloadBehavior = reloadBehavior;
    }
    public void PerformReload(int ammo)
    {
        Ammo = _reloadBehavior.Reload(ammo);
    }    

}
