//using UnityEngine;

//public class WeaponSwitcher 
//{
//    [SerializeField] private Shooter _shooter;

//    private MonoBehaviour _monoContext;

//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Alpha1))
//        {
//            _shooter.CurrentWeapon = new Pistol(10);
//        }
//        else if (Input.GetKeyDown(KeyCode.Alpha2))
//        {
//            _shooter.CurrentWeapon = new PistolUnlim();
//        }
//        else if (Input.GetKeyDown(KeyCode.Alpha3))
//        {
//            _shooter.CurrentWeapon = new Shootgun(12);
//        }
//    }

//    public void Construct(MonoBehaviour monoContext)
//    {
//        _monoContext = monoContext;
//    }
//}
