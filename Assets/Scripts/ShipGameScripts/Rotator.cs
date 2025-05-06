using UnityEngine;

public class Rotator
{
    protected Transform Source;

    public Rotator(Transform source)
    {
        Source = source;
    }

    public void ProcessRotateTo(Vector3 direction, float speed)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        float step = speed * Time.deltaTime;

        Source.rotation = Quaternion.RotateTowards(Source.rotation, lookRotation, step);
    }
}
