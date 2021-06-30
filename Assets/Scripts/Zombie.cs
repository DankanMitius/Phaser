using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public AudioSource thriller;
 public     Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (thriller.mute.Equals(false))
        {
            animator.SetTrigger("dance");
        } 
    }

}
