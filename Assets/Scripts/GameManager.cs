using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0; // Encapsulation: ��ṹ�ͧ������

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
        Time.timeScale = 0; // ��ش��
    }
    public void BackToMenu()
    {
        // ��Ŵ Scene ˹������
        SceneManager.LoadScene("MainMenu");
    }

}