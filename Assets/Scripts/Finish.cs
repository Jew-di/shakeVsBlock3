using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject Play;
    
    void OnTriggerEnter(Collider collision) //������ � ��������
    {
        Destroy (collision.gameObject); // ������� ������
        Debug.Log($"Finish");
        SceneManager.LoadScene(0);
    }
}
