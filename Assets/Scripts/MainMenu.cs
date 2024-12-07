using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // ����¹价�� Scene �ͧ��
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        // �͡�ҡ�� 
        Debug.Log("Game Exited");
        Application.Quit();
    }
}