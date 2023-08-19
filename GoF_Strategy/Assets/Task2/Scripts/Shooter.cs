using UnityEngine;

public class Shooter 
{
    public Weapon CurrentWeapon { get => _currentWeapon; set => _currentWeapon = value; }
    
    private Weapon _currentWeapon;

    private MonoBehaviour _monoContext;

    public void Construct(MonoBehaviour monoContext, Weapon weapon)
    {
        _monoContext = monoContext;
        _currentWeapon = weapon;
    }

    public void Shoot(Weapon weapon)
    {
        weapon.Shoot();
    }

    public void Reload(Weapon weapon)
    {
        weapon.PerformReload();
    }
}

//using UnityEngine;

//public class Shooter
//{
//    public Weapon CurrentWeapon { get => _currentWeapon; set => _currentWeapon = value; }

//    private Weapon _currentWeapon;

//    private MonoBehaviour _monoContext;
//    private void Start()
//    {
//        _currentWeapon = new Pistol(10);
//    }

//    private void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            _currentWeapon.Shoot();
//        }


//        if (Input.GetKeyDown(KeyCode.R))
//        {
//            _currentWeapon.PerformReload(_currentWeapon.FullAmmo);
//        }
//    }

//    public void Construct(MonoBehaviour monoContext)
//    {
//        _monoContext = monoContext;
//    }
//}

