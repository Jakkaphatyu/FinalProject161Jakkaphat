using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ClickableObject
{
    // Method Override: ��˹���á�з�����ͼ����蹤�ԡ�������­
    public override void OnClickAction(GameManager gameManager)
    {
        gameManager.AddScore(1); // ������ṹ
        Destroy(gameObject);    // ź����­�͡
    }
}