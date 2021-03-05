using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotateDummy : MonoBehaviour
{
    public float wheelRadius = 0.35f;
    public Wheel wheel;
    private Vector3 lastFramePos;
    
    void Start()
    {
        lastFramePos = transform.position;
    }

    void Update()
    {
        float moveDistance = Vector3.Dot(transform.position - lastFramePos,wheel.transform.forward);
        float angle = 2f * (float)System.Math.Asin((moveDistance/2f)/wheelRadius) * 180f/3.14f;
        if(!wheel.isBreaking) transform.rotation *= Quaternion.Euler(angle,0,0);
        lastFramePos = transform.position;
    }
}
