using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float Angle = 0;
    private float x, y;
    

    void Start()
    {
       if (gameObject.CompareTag("Bullet"))
       {
            Destroy(gameObject, 3f);
       }
        x = Mathf.Cos(Angle * Mathf.PI / 180) * 8f;
        y = Mathf.Sin(Angle * Mathf.PI / 180) * 8f;
        GetComponent<Rigidbody2D>().velocity= new Vector2(x, y);
        
    }
}
