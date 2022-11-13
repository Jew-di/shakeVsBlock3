using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EatPlayers : MonoBehaviour
{
    public TextMeshPro Eat_text;
    public int Eat = 1;
    private int q;
    

       
    
    void Start()
   
   
    {
        q = Eat; // присваиваем переменной текущее количество поинтов
    }


    void Update()
    {
        Eat_text.text = Eat.ToString(); // выводим текст текущего количества поинтов на объекте
        
    }
   

    void OnTriggerStay () //работа с тригером
    {
        

        for (int n = 0; n < q; n++) // прибавляем поинты н раз
        {
            Game.Heat ++;
        }
        

        Debug.Log($"Eat");
        Destroy(gameObject); // убиваем объект

    }
    
}
