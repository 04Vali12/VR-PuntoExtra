using UnityEngine;
using UnityEngine.Events;



public class Gun : MonoBehaviour
{
    [SerializeField]
    private OVRInput.RawButton _shootButton;
    [SerializeField]

    private UnityEvent _OnShoot;

    [SerializeField]
    private Transform _bulletSpawnPoint;

    private void Update()
    {
        if (OVRInput.GetDown(_shootButton))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        if (_OnShoot != null)
        {
            _OnShoot.Invoke();
        }
    }
}
