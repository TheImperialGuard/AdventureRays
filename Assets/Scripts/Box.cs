using UnityEngine;

public class Box : MonoBehaviour, IDragable
{
    [SerializeField] private LayerMask _dragMask;

    [SerializeField] private float _dragOffset;

    private DragAndDrop _dragAndDrop;

    private void Awake()
    {
        _dragAndDrop = new DragAndDrop(transform, _dragMask, _dragOffset);
    }

    private void FixedUpdate()
    {
        if (_dragAndDrop.IsDragging)
            _dragAndDrop.Drag();
    }

    public void SwitchDragging() => _dragAndDrop.SwitchDragging();
}
