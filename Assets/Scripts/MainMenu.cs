using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // เปลี่ยนไปที่ Scene ของเกม
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        // ออกจากเกม 
        Debug.Log("Game Exited");
        Application.Quit();
    }
}