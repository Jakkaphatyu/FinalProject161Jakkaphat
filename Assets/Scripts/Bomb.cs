using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ClickableObject
{
    // Method Override: กำหนดการกระทำเมื่อผู้เล่นคลิกที่ระเบิด
    public override void OnClickAction(GameManager gameManager)
    {
        gameManager.AddScore(-2); // ลดคะแนน
        Destroy(gameObject);      // ลบระเบิดออก
    }

}