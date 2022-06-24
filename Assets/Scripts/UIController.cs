using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Text playerOneScore, playerTwoScore, playerThreeScore, playerFourScore;
    public Text winnerText;

    public GameObject gameOverPanel;

    private ScoreManager manager;

    private void Start()
    {
        manager = ScoreManager.Instance;
    }

    private void Update()
    {
        
        playerOneScore.text = manager
            .GetPlayerScore(ScoreManager.PlayerNumber.PLAYER_ONE)
            .ToString();

        playerTwoScore.text = manager
            .GetPlayerScore(ScoreManager.PlayerNumber.PLAYER_TWO)
            .ToString();

        playerThreeScore.text = manager
            .GetPlayerScore(ScoreManager.PlayerNumber.PLAYER_THREE)
            .ToString();

        playerFourScore.text = manager
            .GetPlayerScore(ScoreManager.PlayerNumber.PLAYER_FOUR)
            .ToString();
    }

    public void ShowGameOverPanel(int winner)
    {
        winnerText.text = "Player " + winner + " Win";
        gameOverPanel.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("GameplayScene");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
