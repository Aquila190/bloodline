using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class Health : MonoBehaviour
{
    public int maxHealth = 100; 
    private int currentHealth; 
    public Slider healthBar; 

    void Start()
    {
        currentHealth = maxHealth; 

        
        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = currentHealth;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; 
        if (currentHealth < 0) currentHealth = 0; 

        
        if (healthBar != null)
        {
            healthBar.value = currentHealth;
        }

        if (currentHealth <= 0)
        {
            Die(); 
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount; 
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth; 
        }

        
        if (healthBar != null)
        {
            healthBar.value = currentHealth;
        }
    }

    void Die()
    {
        Debug.Log("Karakter öldü!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
