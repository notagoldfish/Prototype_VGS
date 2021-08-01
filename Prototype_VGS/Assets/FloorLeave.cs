using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLeave : MonoBehaviour
{

    public float spd;

    public bool disappear;

    private void Update()
    {
        if (disappear == true)
        {
            transform.Translate(Vector3.forward * spd * Time.deltaTime);
            Destroy(this.gameObject, 20);
        }
    }

}
