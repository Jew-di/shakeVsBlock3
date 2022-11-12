using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public TextMeshPro Heat_text;
    public static int Heat;
    public int SrartingHeat;
  
    
    void Start()
    {
        Heat = SrartingHeat;
    }

    
    void Update()
    {
        Heat_text.text = Heat.ToString();
                
    }
}
