using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class Turn : MonoBehaviour
{
    public PinchSlider slider;
    private float angleValue;

    // Start is called before the first frame update
    void Start()
    {
            angleValue = slider.SliderValue;
        float realangle = 180 * angleValue - 90;
        Debug.Log(realangle);
        transform.Rotate(0, realangle/120, 0);
    }

    // Update is called once per frame
    void Update()
    {
            angleValue = slider.SliderValue;
            Debug.Log(angleValue);
        float realangle = (180 * angleValue - 90);
        transform.Rotate(0, realangle/120, 0);
    }
}
