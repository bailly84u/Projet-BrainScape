using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeChrono : MonoBehaviour
{

    public float temps;
    Text text;

    void Awake()
    {
        text = GetComponent<Text> ();
        temps = 500.0f;
    }

    
    void Update()
    {
        //if ! pause
        // decrementer temps (frame de s)
        temps -= 0.016f;
        text.text = "Temps restant :" + temps;

    }

  
}
