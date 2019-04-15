using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Animator animator;
    public string animToPlay;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLIDED");
        Destroy(gameObject);
        animator.Play(animToPlay);
    }
}
