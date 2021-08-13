//using Score;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    public Score scoreText;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            FindObjectOfType<GameManager2>().EndGame();

        }

        if (collisionInfo.collider.CompareTag("Bonus"))
        {
            FindObjectOfType<Score>().getBonus();

        }

    }
}
