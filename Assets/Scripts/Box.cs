using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, IInteractable
{
    private IInteractable _interactable;

    public void Inizialize(IInteractable interactable)
    {
        _interactable = interactable;
    }

    public void Interact()
    {
        _interactable.Interact();
    }
}
