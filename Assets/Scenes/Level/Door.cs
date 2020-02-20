using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public GameObject dooropen;
    public GameObject room2;

    //public string animationName;
    //Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        //anim = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "Cle1")
        {
            //anim.Play(animationName);
            //Debug.Log("Collision detected");
            door.SetActive(false);
            dooropen.SetActive(true);
            room2.SetActive(true);
        }
    }
}
