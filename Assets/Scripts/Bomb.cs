using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ClickableObject
{
    // Method Override: ��˹���á�з�����ͼ����蹤�ԡ������Դ
    public override void OnClickAction(GameManager gameManager)
    {
        gameManager.AddScore(-2); // Ŵ��ṹ
        Destroy(gameObject);      // ź���Դ�͡
    }

}