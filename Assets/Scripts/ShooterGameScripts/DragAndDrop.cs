using UnityEngine;

public class DragAndDrop
{
    private Transform _source;

    private LayerMask _gridMask;

    private float _yOffset;

    public DragAndDrop(Transform source, LayerMask gridMask, float yOffset)
    {
        _source = source;
        _gridMask = gridMask;
        _yOffset = yOffset;
    }

    public bool IsDragging { get; private set; }

    public void SwitchDragging() => IsDragging = !IsDragging;

    public void Drag()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(cameraRay, out RaycastHit hit, Mathf.Infinity, _gridMask))
        {
            Vector3 dragPosition = new Vector3(hit.point.x, hit.point.y + _yOffset, hit.point.z);

            _source.position = dragPosition;

            Debug.Log(hit.point);
        }
    }
}
