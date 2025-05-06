using UnityEngine;

public class Ship : MonoBehaviour, ISailMovable
{
    [SerializeField] private Transform _hull;
    [SerializeField] private Transform _mast;

    [SerializeField] private float _hullRotationSpeed;
    [SerializeField] private float _mastRotationSpeed;

    [SerializeField] private float _mastRotationLimit;

    private const KeyCode HullLeftKeyCode = KeyCode.A;
    private const KeyCode HullRightKeyCode = KeyCode.D;
    private const KeyCode MastLeftKeyCode = KeyCode.Q;
    private const KeyCode MastRightKeyCode = KeyCode.E;

    private IWindRespondable _windRespondable;

    private Quaternion MastRotationLeftLimit => Quaternion.Euler(0, _mastRotationLimit / -2, 0);
    private Quaternion MastRotationRightLimit => Quaternion.Euler(0, _mastRotationLimit / 2, 0);

    public void SetWindRespond(IWindRespondable windRespondable) => _windRespondable = windRespondable;
    
    private bool IsLimitReached(Transform source, Quaternion limit) => source.localRotation == limit;

    public Vector3 GetSailDirection() => _mast.forward;

    public Vector3 GetMoveDirection() => transform.forward;

    private void Update()
    {
        InputProcess();
    }

    private void FixedUpdate()
    {
        _windRespondable.Respond();
    }

    private void InputProcess()
    {
        if (Input.GetKey(HullLeftKeyCode))
            RotateElement(_hull, -_hullRotationSpeed);

        if (Input.GetKey(HullRightKeyCode))
            RotateElement(_hull, _hullRotationSpeed);

        if (Input.GetKey(MastLeftKeyCode) && IsLimitReached(_mast, MastRotationLeftLimit) == false)
            RotateElement(_mast, -_mastRotationSpeed);

        if (Input.GetKey(MastRightKeyCode) && IsLimitReached(_mast, MastRotationRightLimit) == false)
            RotateElement(_mast, _mastRotationSpeed);
    }

    private void RotateElement(Transform element, float speed)
    {
        element.Rotate(0, speed *  Time.deltaTime, 0);
    }

    public void Move(Vector3 direction)
    {
        transform.position += direction;
    }
}
