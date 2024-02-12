using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI interactableText;

    public void SetInteractableText(string text)
    {
        interactableText.text = text;
    }
}
