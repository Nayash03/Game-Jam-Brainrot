using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public bool isInvincible = false;

    public HealthBar healthBar;

    public AudioSource audioSource;
    public AudioClip sound;

    public VideoPlayer videoPlayer;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    
    void Update()
    {
       

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
        
        StartCoroutine(WaitAfterVideo());
    }

    IEnumerator WaitAfterDead()
    {
        yield return new WaitForSeconds(4f);
        audioSource.Stop();
        videoPlayer.Play(); 
    }

    IEnumerator WaitAfterVideo()
    {
        
        yield return new WaitForSeconds(9f);
    
        SceneManager.LoadScene("Menu"); 
    }

 

}
