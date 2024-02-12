using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField] private Animator doorAnimator;
    public bool IsOpen { get; set; }


    public override string InteractableText
    {
        get
        {
            if (IsOpen)
            {
                return "Close";
            }
            return "Open";
        }
    }

    public override void Interact()
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
    private void Open()
    {
        IsOpen = true;
        doorAnimator.SetBool("IsOpen", true);
    }
    private void Close()
    {
        IsOpen = false;
        doorAnimator.SetBool("IsOpen", false);
    }
}
