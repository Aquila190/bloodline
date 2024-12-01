using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f;   
    public float currentHealth;      

    void Start()
    {
        currentHealth = maxHealth;  
    }

    
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;  

        
        if (currentHealth <= 0)
        {
            HandleDeath();
        }
    }

    
    void HandleDeath()
    {
        
        Debug.Log(gameObject.name + " �ld�!");
        Destroy(gameObject);  
    }
}
