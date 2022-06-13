using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;

public class Unity101_DissapearOnCollision : MonoBehaviour
{
    public ToolTip tooltip;
    private int score;
    private string text; 

    void Start()
    {
        Debug.Log("Start");
        text = tooltip.ToolTipText;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            //Change the Text to the message below
            Debug.Log("Coin collected");
            other.GetComponentInParent<AudioSource>().enabled = true;
            Destroy(other.gameObject);
            score = int.Parse(text) + 1;
            tooltip.ToolTipText = score.ToString();
            Debug.Log(score);
        }


        if (other.gameObject.layer == 31)
        {
            gameObject.GetComponentInParent<AudioSource>().enabled = true;
            gameObject.SetActive(false);
            new WaitForSeconds(5);
            GameObject.Find("race-track").SetActive(false);
            GameObject.Find("Lost").SetActive(true);
        }
    }
}

