using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject UI_Start;
    public GameObject UI_End;

    void Start()
    {
        UI_Start.SetActive(true);
        UI_End.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStart()
    {
        UI_Start.SetActive(false);
        UI_End.SetActive(false);
    }

    public void OnGameOver()
    {
        UI_Start.SetActive(false);
        UI_End.SetActive(true);
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
