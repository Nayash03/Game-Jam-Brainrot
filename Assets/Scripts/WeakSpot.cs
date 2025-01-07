using System.Collections;
using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public GameObject objectToDestroy;
    private bool playerInTrigger = false;

    public Animator animator;
    private bool dead = false;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInTrigger = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInTrigger = false; 
        }
    }

    private void Update()
    {
        
       
        if (playerInTrigger && Input.GetButtonDown("Fire1"))
        {
            dead = true;
            animator.SetTrigger("dead");
            
            StartCoroutine(WaitAndExecute());
            
        }
    }

 

    IEnumerator WaitAndExecute()
    {
        // Attendre 1 seconde
        yield return new WaitForSeconds(1.3f);

        // Code à exécuter après 1 seconde
        Destroy(objectToDestroy); 
    }
}
