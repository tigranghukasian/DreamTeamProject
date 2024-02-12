using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator doorAnimator;
    public bool IsOpen { get; private set; }
    
    public void Interact()
    {
        if (!IsOpen)
        {
            Open();
        }
        else
        {
            Close();
        }
    }
    public void Open()
    {
        IsOpen = true;
        doorAnimator.SetTrigger("DoorOpen");
    }
    public void Close()
    {
        IsOpen = false;
        doorAnimator.SetTrigger("DoorClose");
    }
}
