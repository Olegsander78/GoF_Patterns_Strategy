using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private Weapon _currentWeapon;

    private void Start()
    {
        _currentWeapon = new Pistol();
        _currentWeapon.SetAmmo(10);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _currentWeapon = new Pistol();
            _currentWeapon.SetAmmo(10);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _currentWeapon = new PistolUnlim();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _currentWeapon = new Shootgun();
            _currentWeapon.SetAmmo(12);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _currentWeapon.Reload();
        }

        if (Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shoot();
        }

        //Template method
        if (Input.GetMouseButtonDown(1))
        {
            _currentWeapon.UseWeapon();
        }
    }
}