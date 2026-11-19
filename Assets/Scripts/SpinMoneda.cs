using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMoneda : MonoBehaviour
{
    public float rotation_speed;

    void FixedUpdate(){
        transform.Rotate(new Vector3(0,rotation_speed,0));
    }
}
