using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
  
    [SerializeField] GameObject Bullet;  
    [SerializeField] Transform Eject ; 
    public PlayerMovement playerMovement;  

    void Start()
    {
        // Si la référence au script PlayerMovement n'est pas assignée manuellement dans l'inspecteur,
        // on peut la récupérer automatiquement avec FindObjectOfType
        if (playerMovement == null)
        {
            playerMovement = FindObjectOfType<PlayerMovement>();  // Recherche l'instance de PlayerMovement dans la scène
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bul = Instantiate(Bullet, Eject.position, transform.rotation);
            
            float currentDirection = playerMovement.Direction;
            if (currentDirection == 1)
            {
                bul.GetComponent<Shoot>().Angle = 90;
            }
            if (currentDirection == 2)
            {
                bul.GetComponent<Shoot>().Angle = 180;
            }
            if (currentDirection == 4)
            {
                bul.GetComponent<Shoot>().Angle = 270;
            }


        }
    }
}
