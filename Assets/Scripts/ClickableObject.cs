using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClickableObject : MonoBehaviour
{
    // Encapsulation: ความเร็วในการหายไป
    protected float disappearTime = 3f;

    // Abstract Method
    public abstract void OnClickAction(GameManager gameManager);

    private void Start()
    {
        // ทำลายวัตถุหลังจากเวลาผ่านไป
        Destroy(gameObject, disappearTime);
    }
}