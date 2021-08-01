using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retract : MonoBehaviour
{
    public float spd;

    public bool disappear;

    public int disappearTime;

    private void Update()
    {
        if (disappear == true)
        {
            transform.Translate(-Vector3.forward * spd * Time.deltaTime);
            Invoke("StopDisappearing", disappearTime);
        }
    }

    private void StopDisappearing()
    {
        disappear = false;
    }

    //private void Detract (int centi)
    //{
    //    for (int i = 0; i < centi; i++)
    //    {
    //        transform.
    //    }
    //}
}
