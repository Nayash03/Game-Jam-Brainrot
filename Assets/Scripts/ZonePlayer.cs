using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonePlayer : MonoBehaviour
{
    private bool isLive = true;
    private bool monsterInTrigger = false;
    private bool isOK = false;

    public string levelToLoad;

    public AudioSource audioSource;
    public AudioClip sound;

    public HealthBar healthBar;
    public PlayerHealth playerHealth;
    //private int currentHealth = healthBar.GetCurrentHealth();

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monsters"))
        {
            monsterInTrigger = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Monsters"))
        {
            monsterInTrigger = false; 
        }
    }

    private void FixedUpdate()
    {
        
       
        if (monsterInTrigger && isLive == true)
        {
            
            //currentHealth -= 10;
            //healthBar.SetHealth(currentHealth));

            if (playerHealth.GetCurrentHealth() < 1)
            {
                Debug.Log("Tu est mort");
                audioSource.PlayOneShot(sound);
                isLive = false;
                SceneManager.LoadScene(levelToLoad);

                
            }
            if (isOK)
            {
                playerHealth.TakeDamage(5);
                isOK = false;
            }
            
            
            StartCoroutine(WaitAndExecute());
            
        }
        
    }

    IEnumerator WaitAndExecute()
    {
        // Attendre 1 seconde
        yield return new WaitForSeconds(4f);

        isOK = true;

        
    }

 

    
}
