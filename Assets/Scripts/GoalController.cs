using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public ScoreManager.PlayerNumber playerNumber;
    public GameObject wall;
    public GameObject playerPaddle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ScoreManager.Instance.AddPlayerScore((int) playerNumber, 1);
            BallManager.Instance.IncreaseBallCount(-1);
            other.gameObject.SetActive(false);

            if (ScoreManager.Instance.IsPlayerScoreMax(playerNumber))
            {
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        gameObject.SetActive(false);
        wall.SetActive(true);
        playerPaddle.SetActive(false);
    }
}
