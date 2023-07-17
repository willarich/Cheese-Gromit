using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;  // Reference to the player's transform
    public float followRange = 5f;  // The range within which the enemy will start following the player
    public float moveSpeed = 3f;  // The speed at which the enemy moves towards the player

    private void Update()
    {
        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        // Check if the player is within the follow range
        if (distanceToPlayer <= followRange)
        {
            // Calculate the direction towards the player
            Vector2 direction = (player.position - transform.position).normalized;

            // Move the enemy towards the player
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}