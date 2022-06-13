using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;

public class End : MonoBehaviour
{
    public ToolTip TimeTooltip;
    public ToolTip ScoreTooltip;
    public GameObject end;
    private int score;
    private string time;

    void Update()
    {
        score = int.Parse(ScoreTooltip.ToolTipText);
        time = TimeTooltip.ToolTipText;
        if (score == 10)
        {
            end.SetActive(true);
            end.GetComponentInChildren<TextMeshPro>().SetText("You collected " + score + " coins" + "in " + time + ". Well done!");
            GameObject.Find("race-track").SetActive(false);
        }

    }
}
