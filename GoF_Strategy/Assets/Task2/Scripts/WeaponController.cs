//using UnityEngine;

//public class WeaponController : MonoBehaviour
//{
//    private Weapon _currentWeapon;

//    private void Start()
//    {
//        _currentWeapon = new Pistol(10,1);
//    }

//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Alpha1))
//        {
//            _currentWeapon = new Pistol(10,1);
//        }
//        else if (Input.GetKeyDown(KeyCode.Alpha2))
//        {
//            _currentWeapon = new PistolUnlim();
//        }
//        else if (Input.GetKeyDown(KeyCode.Alpha3))
//        {
//            _currentWeapon = new Shootgun(12,3);
//        }

//        if (Input.GetKeyDown(KeyCode.R))
//        {
//            _currentWeapon.Reload();
//        }

//        if (Input.GetMouseButtonDown(0))
//        {
//            _shooter._currentWeapon.Shoot();
//        }
//    }
//}