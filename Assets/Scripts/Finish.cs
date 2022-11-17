using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject Play;
    
    void OnTriggerEnter(Collider collision) //работа с тригером
    {
        Destroy (collision.gameObject); // убиваем объект
        Debug.Log($"Finish");
        SceneManager.LoadScene(0);
    }
}
