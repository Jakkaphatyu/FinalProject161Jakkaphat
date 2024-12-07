using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private void OnMouseDown()
    {
        ClickableObject clickableObject = GetComponent<ClickableObject>();
        if (clickableObject != null)
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            clickableObject.OnClickAction(gameManager);
        }
    }
}