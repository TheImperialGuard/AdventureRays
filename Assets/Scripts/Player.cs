using UnityEngine;

public class Player : MonoBehaviour
{
    private const KeyCode PrimaryShooterKeyCode = KeyCode.Mouse0;
    private const KeyCode SecondaryShooterKeyCode = KeyCode.Mouse1;

    private IShooter _primaryShooter;
    private IShooter _secondaryShooter;

    public void SetPrimaryShooter(IShooter shooter) => _primaryShooter = shooter;

    public void SetSecondaryShooter(IShooter shooter) => _secondaryShooter = shooter;

    private Ray GetCameraRay() => Camera.main.ScreenPointToRay(Input.mousePosition);

    private void Update()
    {
        Ray cameraRay = GetCameraRay();

        if (Input.GetKeyDown(PrimaryShooterKeyCode))
            _primaryShooter.Shoot(cameraRay.origin, cameraRay.direction);

        if (Input.GetKeyDown(SecondaryShooterKeyCode))
            _secondaryShooter.Shoot(cameraRay.origin, cameraRay.direction);
    }
}
