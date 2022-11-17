using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMuvi : MonoBehaviour
{
    public float MinVsMaxX = 4f;
    public float SpeedPlayer = 1;
    public float SpeedPlayerRot = 10;
    public float horizInput;
    public static float TecSpeedPlayer;
    private float a;

    

    void Update()
    {

        if (transform.position.x < -MinVsMaxX) // �������� ��������� �� ��� �
        {
            transform.position = new Vector3(-MinVsMaxX, transform.position.y, transform.position.z); //���������� ��� �
        }
        if (transform.position.x > MinVsMaxX)
        {
            transform.position = new Vector3(MinVsMaxX, transform.position.y, transform.position.z);
        }
        
        horizInput = Input.GetAxis("Horizontal"); // ���������� ������ �������� �� ��� �
        transform.Translate(Vector3.right * horizInput * Time.deltaTime * SpeedPlayerRot);
        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * SpeedPlayer /2; //������ �������� ����� �� ��� Z

        TecSpeedPlayer = SpeedPlayer; // ��������� ��������� ��������� ��� ��������� ��������

        if (Input.GetKeyDown("W".ToLower())) // ��� ������� W �������� �����
        {
            a = TecSpeedPlayer;
            TecSpeedPlayer = a + 1;
        }
        if (Input.GetKeyDown("S".ToLower()))
        {
            a = TecSpeedPlayer;
            TecSpeedPlayer = a - 1;
        }


        SpeedPlayer =TecSpeedPlayer;


       
    }
}
