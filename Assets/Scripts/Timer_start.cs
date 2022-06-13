using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class Timer_start : MonoBehaviour
{
    public ToolTip tooltip;
    private float time;

    void Update()
    {
        time += Time.deltaTime;
        tooltip.ToolTipText = (time).ToString("0") + " s";
        if (time < 0)
        {
            //Do something useful or Load a new game scene depending on your use-case
        }
    }
}
