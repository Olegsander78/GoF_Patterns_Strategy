using System.Collections.Generic;
using UnityEngine;

public class WeaponSystemInstaller : MonoBehaviour
{
    [SerializeField] private Shooter _shooter = new Shooter();

    [SerializeField]
    private List<Weapon> _weapons = new() { new Pistol(10,10,1), new PistolUnlim(1), new Shootgun(12, 12, 3) };

    private Weapon _currentWeapon;

    private void Start()
    {
        _currentWeapon = _weapons[0];

        _shooter.Construct(monoContext: this, _currentWeapon);
    }

    private void Update()
    {
        SwitchWeapon();
        Shoot();
        Reload();
    }

    public void SwitchWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _currentWeapon = _weapons[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _currentWeapon = _weapons[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _currentWeapon = _weapons[2];
        }
    }

    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _shooter.Shoot(_currentWeapon);
        }
    }

    public void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _shooter.Reload(_currentWeapon);
        }
    }
}
