using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Play;
    
    void OnTriggerEnter(Collider collision) //������ � ��������
    {
        Destroy (collision.gameObject); // ������� ������
        Debug.Log($"Finish");
    }
}
