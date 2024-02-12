using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactableText;
    public virtual string InteractableText => interactableText;

    public virtual void Interact()
    {
        
    }
}
