using UnityEngine;

public class Wind : MonoBehaviour
{
    [SerializeField] float _changeDirectionFrequency;

    [SerializeField] int _changeDirectionLowerLimit;
    [SerializeField] int _changeDirectionUpperLimit;


    private float _time;

    [field: SerializeField] public float Power { get; }

    public Vector3 Direction => transform.forward;

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time > _changeDirectionFrequency)
        {
            ChangeDirection();

            _time = 0;
        }
    }

    private void ChangeDirection()
    {
        int changingDirection = Random.Range(0, 2) == 0 ? -1 : 1;

        float degrees = Random.Range(_changeDirectionLowerLimit, _changeDirectionUpperLimit + 1) * changingDirection;

        transform.rotation = Quaternion.Euler(0, degrees, 0);
    }
}
