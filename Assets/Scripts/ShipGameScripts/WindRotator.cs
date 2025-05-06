using UnityEngine;

public class WindRotator : Rotator, IWindRespondable
{
    private Wind _wind;

    private float _speed;

    public WindRotator(Transform source, Wind wind, float speed) : base(source)
    {
        _wind = wind;
        _speed = speed;
    }

    public void Respond()
    {
        if (Source.forward != _wind.Direction)
        {
            ProcessRotateTo(_wind.Direction, _speed);
        }
    }
}
