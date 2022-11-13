using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Play;
    
    void OnTriggerEnter(Collider collision) //работа с тригером
    {
        Destroy (collision.gameObject); // убиваем объект
        Debug.Log($"Finish");
    }
}
