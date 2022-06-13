using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour{

    public GameObject Car;

    private void OnTriggerEnter(Collider other) 
    {
        Destroy(Car);
        GetComponent<AudioSource>().enabled = true;

    }
}

