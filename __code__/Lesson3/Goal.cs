using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameManager mainScript;      

    private void OnTriggerEnter(Collider other)
    {
        mainScript.OnGameOver();
    }
}
