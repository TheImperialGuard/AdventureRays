using UnityEngine;

public class InteractEffect : IShootEffect
{
    public void Execute(Vector3 hitPoint, Collider collider)
    {
        IInteractable target = collider.GetComponent<IInteractable>();

        if (target != null)
        {
            target.Interact();
        }
    }
}
