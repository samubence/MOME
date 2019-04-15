using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject objToFollow;

    Vector3 offset;

    void Start()
    {
        offset = transform.position - objToFollow.transform.position;    
    }


    void Update()
    {
        transform.position = objToFollow.transform.position + offset;    
    }
}
