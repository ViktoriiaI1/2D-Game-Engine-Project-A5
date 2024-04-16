using UnityEngine.EventSystems;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    public GameManager gameManager;
    public bool isPlayerCollider;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isPlayerCollider)
        {
            gameManager.ComputerScores();
        }
        else
        {
            gameManager.PlayerScores();
        }
        
    }
}
