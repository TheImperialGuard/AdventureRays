using UnityEngine;

public interface ISailMovable
{
    Vector3 GetSailDirection();
    Vector3 GetMoveDirection();

    void Move(Vector3 direction);
}
