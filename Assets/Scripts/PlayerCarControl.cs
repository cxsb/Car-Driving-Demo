using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarControl : MonoBehaviour
{
    public Car car;

    // Update is called once per frame
    void Update()
    {
        car.PressedAccelerator(Input.GetAxis("Vertical"));
        car.Turn(Input.GetAxis("Horizontal"));
        car.PressBreak(Input.GetKey(KeyCode.Space));
    }
}
