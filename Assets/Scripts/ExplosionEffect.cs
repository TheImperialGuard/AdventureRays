using UnityEngine;

public class ExplosionEffect : IShootEffect
{
    private float _radius;
    private float _force;

    private LayerMask _mask;

    public ExplosionEffect(float radius, float force, LayerMask mask)
    {
        _radius = radius;
        _force = force;
        _mask = mask;
    }

    public void Execute(Vector3 hitPoint, Collider collider)
    {
        Collider[] targets = Physics.OverlapSphere(hitPoint, _radius, _mask);

        foreach (Collider target in targets)
        {
            Rigidbody rigidbody = target.GetComponent<Rigidbody>();

            if (rigidbody != null)
            {
                Push(hitPoint, rigidbody);
                Debug.Log(rigidbody.gameObject.name);
            }
        }
    }

    private void Push(Vector3 explosionCenter, Rigidbody rigidbody)
    {
        Vector3 direction = rigidbody.transform.position - explosionCenter;

        float additionalForce = (_radius - direction.magnitude) * _force;

        Vector3 force = direction.normalized * additionalForce;

        rigidbody.AddForce(force, ForceMode.Impulse);
    }
}
