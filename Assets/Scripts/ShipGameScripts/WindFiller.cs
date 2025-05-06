using UnityEngine;

public class WindFiller : MonoBehaviour
{
    [SerializeField] private Flag _flag;
    [SerializeField] private Ship _ship;

    [SerializeField] private float _flagRespondSpeed;
    [SerializeField] private float _shipRespondSpeed;

    private Wind _wind;

    private void Awake()
    {
        _wind = GetComponent<Wind>();

        _flag.SetWindRespond(new WindRotator(_flag.transform, _wind, _flagRespondSpeed));

        _ship.SetWindRespond(new WindSailMover(_ship, _wind, _shipRespondSpeed));
    }
}
