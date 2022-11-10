using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public GameObject Playerss;
    public int SpeedPlayer;
    public Vector3 PozhinPlayer = new Vector3(0, 0.5f, 0);
    void Update()
    {
        if (Input.GetKeyDown("D".ToLower()))
        {
            Playerss.transform.position += Playerss.transform.right * 1f;
        }
        if (Input.GetKeyDown("A".ToLower()))
        {
            Playerss.transform.position += Playerss.transform.right * -1f;
        }
    }
}