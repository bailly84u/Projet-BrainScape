using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsChanger : MonoBehaviour
{
    public GameObject musicSlider;
    public GameObject soundSlider;

    private float musicLevel;
    private float soundLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getMusicLevel()
    {
        musicLevel = musicSlider.GetComponent<Slider>().value;
        print(musicLevel);
    }
    void getSoundLevel()
    {

    }
}
