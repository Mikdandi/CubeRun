
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
     void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("We hit an Obstacle");
        }
       

    }
}
