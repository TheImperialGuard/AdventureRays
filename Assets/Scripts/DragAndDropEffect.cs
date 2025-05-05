using UnityEngine;

public class DragAndDropEffect : IShootEffect
{
    public void Execute(Vector3 hitPoint, Collider collider)
    {
        IDragable target = collider.GetComponent<IDragable>();

        if (target != null)
        {
            target.SwitchDragging();
        }
    }
}
