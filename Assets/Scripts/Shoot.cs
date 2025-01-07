using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Animator animator;
    

    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetFloat("attack", 1);
        }
        
    }
}
