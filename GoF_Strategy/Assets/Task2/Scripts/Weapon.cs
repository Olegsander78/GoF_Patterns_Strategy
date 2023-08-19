public abstract class Weapon
{
    public int AmmoCurrent { get; protected set; }
    public int AmmoCapacity { get; protected set; }
    protected int AmmoPerShoot;

    protected IReloadBehavior _reloadBehavior;

    protected Weapon()
    {
    }
    protected Weapon(int ammoCapacity, int ammoCurrent, int ammoPerShoot, IReloadBehavior reloadBehavior)
    {
        AmmoCapacity = ammoCapacity;
        AmmoCurrent = ammoCurrent;
        AmmoPerShoot = ammoPerShoot;

        _reloadBehavior = reloadBehavior;
    }
    public abstract void Shoot();
    
    public void SetReloadBehavior(IReloadBehavior reloadBehavior)
    {
        _reloadBehavior = reloadBehavior;
    }
    public void PerformReload()
    {
        AmmoCurrent = _reloadBehavior.Reload(AmmoCapacity);
    }    

}
