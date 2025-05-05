using UnityEngine;

public class VirtualCursor : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;

    [SerializeField] private float _yOffset;

    private void Update()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(cameraRay, out RaycastHit hitInfo, _mask))
            transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y + _yOffset, hitInfo.point.z);
    }
}
