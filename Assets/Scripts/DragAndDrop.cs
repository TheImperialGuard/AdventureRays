using UnityEngine;

public class DragAndDrop : IInteractable
{
    private Transform _source;
    private Transform _cursor;

    private bool _isDragging = false;

    public DragAndDrop(Transform source, Transform cursore)
    {
        _source = source;
        _cursor = cursore;
    }

    public void Interact()
    {
        _isDragging = !_isDragging;

        if (_isDragging)
            Drag();
        else
            Drop();
    }

    private void Drop()
    {
        _source.SetParent(null);
    }

    private void Drag()
    {
        _source.SetParent(_cursor);
    }
}
