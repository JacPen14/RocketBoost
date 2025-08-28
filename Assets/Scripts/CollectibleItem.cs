using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private void RotateCollectible()
    {
        // Rotate the item for a simple animation effect
        transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //If we hit the player
        {
            // Add code here to update the player's score or inventory
            Debug.Log("Item collected!");
            // Destroy the collectible item
            Destroy(gameObject);
        }
    }
}
