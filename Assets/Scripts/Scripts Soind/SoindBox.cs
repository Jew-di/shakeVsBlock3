using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoindBox : MonoBehaviour
{

    public AudioSource BoxSoinds;

    private void OnTriggerEnter(Collider other)
    {
        BoxSoinds.Play();
    }
}


   