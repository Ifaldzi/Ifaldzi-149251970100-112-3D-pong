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

    public int maxScore;

    public static ScoreManager Instance;

    public int[] playerScores = { 0, 0, 0, 0 };

    private void Awake()
    {
        Instance = this;
    }

    public void AddPlayerScore(int playerNumber, int increment)
    {
        playerScores[playerNumber] += increment;

        if (IsGameOver())
        {
            GameOver();
        }
    }

    public int GetPlayerScore(PlayerNumber playerNumber)
    {
        return playerScores[(int)playerNumber];
    }

    public bool IsPlayerScoreMax(PlayerNumber playerNumber)
    {
        return GetPlayerScore(playerNumber) >= maxScore;
    }

    private bool IsGameOver()
    {
        int totalActivePlayer = playerScores.Length;
        foreach (int score in playerScores)
        {
            if (score >= maxScore)
                totalActivePlayer--;
        }

        if (totalActivePlayer > 1)
            return false;

        return true;
    }

    private void GameOver()
    {
        int winner = FindWinningPlayer();
        Debug.Log("Game Over, Win player " + winner);
    }

    private int FindWinningPlayer()
    {
        for(int i = 0; i < playerScores.Length; i++)
        {
            if (playerScores[i] < maxScore)
                return i + 1;
        }

        return 0;
    }
}
