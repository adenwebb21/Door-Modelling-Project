using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPlayer : MonoBehaviour {

    Animator animator;
    AudioSource creak;

    private void Start()
    {
        creak = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("playerInRANGE");
        creak.Play();
    }
}
