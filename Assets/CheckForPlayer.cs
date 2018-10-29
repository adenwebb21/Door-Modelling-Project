using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPlayer : MonoBehaviour {

    Animator animator;
    AudioSource creak;
    private float delay;

    private void Start()
    {
        creak = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        delay = 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("boltTrigger");
        creak.Play();
    }
}
