using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nightstand : MonoBehaviour
{
	
	
    public GameObject nightstandopen;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	 void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "Cle1")
        {
            nightstandopen.SetActive(true);

        }
    }
}
