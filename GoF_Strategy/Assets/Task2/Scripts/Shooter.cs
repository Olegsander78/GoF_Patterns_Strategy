using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Weapon CurrentWeapon { get => _currentWeapon; set => _currentWeapon = value; }
    
    private Weapon _currentWeapon;

    private void Start()
    {
        _currentWeapon = new Pistol(10, 1);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shoot();
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            _currentWeapon.Reload();
        }
    }
}
