using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClickableObject : MonoBehaviour
{
    // Encapsulation: ��������㹡������
    protected float disappearTime = 3f;

    // Abstract Method
    public abstract void OnClickAction(GameManager gameManager);

    private void Start()
    {
        // ������ѵ����ѧ�ҡ���Ҽ�ҹ�
        Destroy(gameObject, disappearTime);
    }
}