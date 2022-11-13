using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoindEat : MonoBehaviour
{
    
    public AudioSource EatsSoinds;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag != "Player")
        EatsSoinds.Play();
    }
}
