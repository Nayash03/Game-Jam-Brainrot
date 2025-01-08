using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMobs : MonoBehaviour
{
    [SerializeField] GameObject Bullet;  
    [SerializeField] Transform Eject ; 

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject bul = Instantiate(Bullet, Eject.position, transform.rotation);
        }


        
    }
}
