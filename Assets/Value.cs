using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Value : MonoBehaviour
{
    private Slider mainSlider;

    //Invoked when a submit button is clicked.
    void Update()
    {
        //Displays the value of the slider in the console.
        Debug.Log(mainSlider.value);
    }
}
