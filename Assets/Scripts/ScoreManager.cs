using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public enum PlayerNumber 
    { 
        PLAYER_ONE = 0, 
        PLAYER_TWO = 1, 
        PLAYER_THREE = 2, 
        PLAYER_FOUR = 3 
    }

    public static ScoreManager Instance;

    public int[] playerScores = { 0, 0, 0, 0 };

    private void Awake()
    {
        Instance = this;
    }

    public void AddPlayerScore(int playerNumber, int increment)
    {
        playerScores[playerNumber] += increment;
    }

    public int GetPlayerScore(PlayerNumber playerNumber)
    {
        return playerScores[(int)playerNumber];
    }
}
