using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticuleDetector : MonoBehaviour
{
    [HideInInspector]
    public int compteurSolide1;
    public int compteurSolide2;
    public int compteurSolide3;
    public int compteurSolide4;
    public GameObject ModeleSolidePlein;

    private void Start()
    {
        compteurSolide1 = 0;
        compteurSolide2 = 0;
    }
    private void Update()
    {
        if (compteurSolide1==4 && compteurSolide2==2)
        {
            ModeleSolidePlein.SetActive(true);

        }
      
    }

    void OnCollisionEnter(Collision col)
    {
        print("test");
        if (col.gameObject.tag.Equals("Solide1"))
        {
            compteurSolide1++;

        }
        if (col.gameObject.tag.Equals("Solide2"))
        {
            compteurSolide2++;

        }
    }

    private void OnCollisionExit(Collision col)
    {
        print("test2");
        if (col.gameObject.tag.Equals("Solide1"))
        {
            compteurSolide1--;

        }
        if (col.gameObject.tag.Equals("Solide2"))
        {
            compteurSolide2--;

        }
    }
}
