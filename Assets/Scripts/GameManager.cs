using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0; // Encapsulation: คะแนนของผู้เล่น

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    private void Start()
    {
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();

        if (score < 0)
        {
            GameOver();
        }
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score;
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0; // หยุดเกม
    }
    public void BackToMenu()
    {
        // โหลด Scene หน้าเมนู
        SceneManager.LoadScene("MainMenu");
    }

}