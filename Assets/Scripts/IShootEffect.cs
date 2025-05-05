using UnityEngine;

public interface IShootEffect
{
    void Execute(Vector3 hitPoint, Collider collider);
}
