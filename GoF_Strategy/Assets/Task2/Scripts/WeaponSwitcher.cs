using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] private Shooter _shooter;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _shooter.CurrentWeapon = new Pistol(10);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _shooter.CurrentWeapon = new PistolUnlim();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _shooter.CurrentWeapon = new Shootgun(12);
        }
    }
}
