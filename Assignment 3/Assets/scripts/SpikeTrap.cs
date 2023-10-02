using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Doctor"))
        {
            // Handle player collision with spike (e.g., deal damage, disable player, etc.)
            collision.GetComponent<Health>().TakeDamage(0.5f);
        }
    }
}
