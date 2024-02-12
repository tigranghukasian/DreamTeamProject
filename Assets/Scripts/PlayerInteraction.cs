using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactionDistance = 3f;
    [SerializeField] private Camera camera;
    [SerializeField] private LayerMask interactableMask;
    [SerializeField] private UIManager uiManager;
    private void Update()
    {

            Ray ray = new Ray(camera.transform.position, camera.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactionDistance, interactableMask))
            {
                if (hit.collider.TryGetComponent(out IInteractable interactable))
                {
                    uiManager.SetInteractableText(interactable.InteractableText);
                    if (Input.GetMouseButtonDown(0))
                    {
                        interactable.Interact();
                    }

                }
                else
                {
                    uiManager.SetInteractableText(string.Empty);
                }
            }
            else
            {
                uiManager.SetInteractableText(string.Empty);
            }
    }
}
