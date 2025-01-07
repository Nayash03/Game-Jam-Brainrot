using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    void Start()
    {
       if (gameObject.CompareTag("Bullet"))
       {
            Destroy(gameObject, 3f);
       }
       GetComponent<Rigidbody2D>().velocity= new Vector2(0, 1) * 4f;
        
    }
}
