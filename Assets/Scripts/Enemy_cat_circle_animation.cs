using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_cat_circle_animation : MonoBehaviour
{

    public Animator animator;

    
    void Update()
    {
        int randomAnimation = Random.Range(1, 10);
        animator.SetFloat("random", randomAnimation);
        
        
    }
}
