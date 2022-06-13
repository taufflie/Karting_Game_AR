using UnityEngine;
using System.Threading;

public class Move_Car : MonoBehaviour
{
    public GameObject Car;
    private void Start()
    {
        //Car.GetComponent<Rigidbody>().useGravity = true;
    }
    void FixedUpdate()
    {
        Car.transform.Translate(0,0,0.003f);
    }
}