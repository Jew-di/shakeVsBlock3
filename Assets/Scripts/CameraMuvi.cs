using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMuvi : MonoBehaviour
{
    public float SpeedPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += gameObject.transform.up * Time.deltaTime * PlayerMuvi.TecSpeedPlayer; // задали движение камере, со скоростью движения игрока
        gameObject.transform.position += gameObject.transform.up * Time.deltaTime * SpeedPlayer / 2;
    }
}
