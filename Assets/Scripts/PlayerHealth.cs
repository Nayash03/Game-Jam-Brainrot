using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public bool isInvincible = false;

    public HealthBar healthBar;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
            isInvincible = true;
            StartCoroutine(HandleInvicibilityDelay());
        }
        
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public IEnumerator HandleInvicibilityDelay()
    {
        while (isInvincible)
        {
            yield return new WaitForSeconds(3f);
            isInvincible = false;
        }
        


        
    }

 

}
