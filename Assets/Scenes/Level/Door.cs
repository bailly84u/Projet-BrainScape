using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables.PhysicsBased;

public class Door : MonoBehaviour
{
    public GameObject door;
    public GameObject dooropen;
    public GameObject room2;
    public GameObject slider1;
    public float val1;
    public GameObject slider2;
    public float val2;
    public GameObject slider3;
    public float val3;
    public GameObject slider4;
    public float val4;

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
        val1 = slider1.GetComponent<VRTK_PhysicsSlider>().GetValue();
        val2 = slider2.GetComponent<VRTK_PhysicsSlider>().GetValue();
        val3 = slider3.GetComponent<VRTK_PhysicsSlider>().GetValue();
        val4 = slider4.GetComponent<VRTK_PhysicsSlider>().GetValue();
        //print(val1);
        //print(slider3.GetComponent<VRTK_PhysicsSlider>().GetStepValue(val3));
        //si le code entré est bon on desactive la porte
        if (slider1.GetComponent<VRTK_PhysicsSlider>().GetStepValue(val1) == 1 & slider2.GetComponent<VRTK_PhysicsSlider>().GetStepValue(val2) == 2 & slider3.GetComponent<VRTK_PhysicsSlider>().GetStepValue(val3) == 3 & slider4.GetComponent<VRTK_PhysicsSlider>().GetStepValue(val4) == 4)
        {
            door.SetActive(false);
            dooropen.SetActive(true);
            room2.SetActive(true);
        }
    }
    /*void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name == "Cle1")
        {
            //anim.Play(animationName);
            //Debug.Log("Collision detected");
            door.SetActive(false);
            dooropen.SetActive(true);
            room2.SetActive(true);
        }
    }*/

}
