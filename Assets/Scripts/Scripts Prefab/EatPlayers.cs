using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EatPlayers : MonoBehaviour
{
    public TextMeshPro Eat_text;
    public int Eat = 1;
    private int q;

   private AudioSource myAudioSource;
    
    
    void Start()
   
   
    {
        q = Eat; // ����������� ���������� ������� ���������� �������
        myAudioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        Eat_text.text = Eat.ToString(); // ������� ����� �������� ���������� ������� �� �������
        
    }
   // void OnTriggerEnter()
    //{
   //     myAudioSource.enabled = true;
   // }

    void OnTriggerEnter () //������ � ��������
    {
        

        for (int n = 0; n < q; n++) // ���������� ������ � ���
        {
            Game.Heat ++;
        }
        

        Debug.Log($"Eat");
        myAudioSource.enabled = true;
        Destroy(gameObject); // ������� ������

    }
    
}
