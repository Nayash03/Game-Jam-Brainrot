using System.Collections;
using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public GameObject objectToDestroy;
    private bool playerInTrigger = false;

    public Animator animator;
    private bool dead = false;
    public float timerDead;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            playerInTrigger = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            playerInTrigger = false; 
        }
    }

    private void Update()
    {
        
       
        if (playerInTrigger)
        {
            dead = true;
            animator.SetTrigger("dead");
            
            StartCoroutine(WaitAndExecute());
            
        }
    }

 

    IEnumerator WaitAndExecute()
    {
        // Attendre 1 seconde
        yield return new WaitForSeconds(timerDead);

        // Code à exécuter après 1 seconde
        Destroy(objectToDestroy); 
    }
}
