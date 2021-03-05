using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public WheelCollider wheelCollider;
    public bool isBreaking;

    public void AddAcc(float acc)
    {
        wheelCollider.motorTorque = acc;
    }

    public void Turn(float turn)
    {
        transform.rotation = transform.parent.rotation * Quaternion.Euler(0,turn,0);
        wheelCollider.steerAngle = turn;
    }

    public void Break(float acc)
    {
        if(acc < 1)
        {
            isBreaking = false;
        }
        else
        {
            isBreaking = true;
        }
        wheelCollider.brakeTorque = acc;
    }
}
