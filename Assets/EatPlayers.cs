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
        q = Eat;
    }


    void Update()
    {
        Eat_text.text = Eat.ToString();
    }
    void OnTriggerEnter()
    {
        for (int n = 0; n < q; n++)
        {
            Game.Heat ++;   
        }
            Debug.Log($"Eat");
        Destroy(gameObject);
    }
}
