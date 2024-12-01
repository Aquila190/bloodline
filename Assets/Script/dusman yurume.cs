using UnityEngine;

public class EnemyChaseWithGravity : MonoBehaviour
{
    public Transform player;  
    public float moveSpeed = 3f;  
    private bool isChasing = false;  

    private Rigidbody2D rb;  
    private Vector2 direction;  

    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
        if (isChasing && player != null)
        {
            
            direction = new Vector2(player.position.x - transform.position.x, 0).normalized;

            
            rb.linearVelocity = new Vector2(direction.x * moveSpeed, rb.linearVelocity.y);
        }
        else
        {
            
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Oyuncu"))
        {
            isChasing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.CompareTag("Oyuncu"))
        {
            isChasing = false;
        }
    }
}
