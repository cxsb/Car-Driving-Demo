using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public int accRatio = 1000;
    public int turnRatio = 10;

    public Wheel FLwheel;
    public Wheel FRwheel;
    public Wheel BLwheel;
    public Wheel BRwheel;


    public void PressedAccelerator(float acc)
    {
        float verticalAcc = acc * accRatio;
        BLwheel.AddAcc(verticalAcc);
        BRwheel.AddAcc(verticalAcc);
    }
    
    public void Turn(float acc)
    {
        float horizontalAcc = acc * turnRatio;
        FLwheel.Turn(horizontalAcc);
        FRwheel.Turn(horizontalAcc);
    }

    public void PressBreak(bool isBreak)
    {
        if(isBreak)
        {
            BLwheel.Break(accRatio);
            BRwheel.Break(accRatio);
            FLwheel.Break(accRatio);
            FRwheel.Break(accRatio);
        }
        else
        {
            BLwheel.Break(0);
            BRwheel.Break(0);
            FLwheel.Break(0);
            FRwheel.Break(0);
        }
    }
    
}
