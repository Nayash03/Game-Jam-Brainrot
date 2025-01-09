using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public bool isInvincible = false;

    public HealthBar healthBar;

    public AudioSource audioSource;
    public AudioClip sound;
    
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


            if (currentHealth < 1)
            {
                die();
                return;
              
                 
            }

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

    public void die()
    {
        Debug.Log("Tu est mort");
        PlayerMovement.instance.enabled = false;
        audioSource.PlayOneShot(sound);
        StartCoroutine(WaitAfterDead());
    }

    IEnumerator WaitAfterDead()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Menu"); 
    }

 

}
