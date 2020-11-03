using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision colInfo)
    {
        if (colInfo.collider.tag == "Cube") {
            movement.enabled=false;
            Debug.Log("Collided with: "+colInfo.collider.tag);
        }
    }
}
