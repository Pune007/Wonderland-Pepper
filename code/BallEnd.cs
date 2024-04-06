using UnityEngine;

public class GroundController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the triggering object is tagged as "Ball"
        if (other.CompareTag("Ball"))
        {
            // Trigger game over
         
        }
    }

}