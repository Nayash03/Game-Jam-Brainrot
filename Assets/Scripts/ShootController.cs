using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
  
    [SerializeField] GameObject Bullet;  
    [SerializeField] Transform Eject ; 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, Eject.position, transform.rotation);
        }
    }
}
