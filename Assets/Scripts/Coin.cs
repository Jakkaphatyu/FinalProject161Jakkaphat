using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ClickableObject
{
    // Method Override: กำหนดการกระทำเมื่อผู้เล่นคลิกที่เหรียญ
    public override void OnClickAction(GameManager gameManager)
    {
        gameManager.AddScore(1); // เพิ่มคะแนน
        Destroy(gameObject);    // ลบเหรียญออก
    }
}