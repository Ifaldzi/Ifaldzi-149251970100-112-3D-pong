using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text playerOneScore, playerTwoScore, playerThreeScore, playerFourScore;

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
}
