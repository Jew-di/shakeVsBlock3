using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Play;
    
    void OnTriggerEnter() //работа с тригером
    {
        Debug.Log($"Finish");
        Destroy(Play); // убиваем объект
    }
}
