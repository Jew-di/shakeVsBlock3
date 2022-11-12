using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxPrefab : MonoBehaviour
{
    public TextMeshPro Box_text;
    public int Box = 1;
    private int q;
    void Start()
    {
        q = Box;
    }


    void Update()
    {
        Box_text.text = Box.ToString();
    }
    void OnTriggerEnter()
    {
        for (int n = 0; n < q; n++)
        {
            Game.Heat--;
        }
        Debug.Log($"Box");
        Destroy(gameObject);
    }
}
