using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public ScoreManager.PlayerNumber player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ScoreManager.Instance.AddPlayerScore((int) player, 1);
            BallManager.Instance.IncreaseBallCount(-1);
            other.gameObject.SetActive(false);
        }
    }
}
