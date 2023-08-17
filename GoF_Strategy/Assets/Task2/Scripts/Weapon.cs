public abstract class Weapon
{
    protected int Ammo;
    protected int AmmoPerShoot;

    protected Weapon()
    {
    }
    protected Weapon(int ammo, int ammoPerShoot)
    {
        Ammo = ammo;
        AmmoPerShoot = ammoPerShoot;
    }

    public abstract void Shoot();
    public abstract void Reload();
}
