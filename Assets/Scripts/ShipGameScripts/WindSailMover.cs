using UnityEngine;

public class WindSailMover : IWindRespondable
{
    private ISailMovable _source;

    private Wind _wind;

    private float _speed;

    public WindSailMover(ISailMovable source, Wind wind, float speed)
    {
        _source = source;
        _wind = wind;
        _speed = speed;
    }

    public void Respond()
    {
        float sailDotProduct = Vector3.Dot(_source.GetSailDirection(), _wind.Direction);

        float sourceDotProduct = Vector3.Dot(_source.GetMoveDirection(), _wind.Direction);

        float finalSpeed = _speed * sailDotProduct * sourceDotProduct * Time.deltaTime;

        if (sailDotProduct < 0 || sourceDotProduct < 0)
            finalSpeed = 0;

        _source.Move(_source.GetMoveDirection() * finalSpeed);

        Debug.Log(_speed * sailDotProduct * sourceDotProduct);
    }
}
