using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Player _player;

    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;

    [SerializeField] private LayerMask _explosionMask;

    private void Awake()
    {
        _player.SetPrimaryShooter(new RayShooter(new DragAndDropEffect()));
        _player.SetSecondaryShooter(new RayShooter(new ExplosionEffect(_explosionRadius, _explosionForce, _explosionMask)));
    }
}
