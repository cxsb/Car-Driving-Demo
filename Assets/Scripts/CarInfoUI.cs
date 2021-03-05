using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInfoUI : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    public GameObject pin;
    public Car car;
    private Vector3 lastFramePos;
    // Start is called before the first frame update
     void Start()
    {
        lastFramePos = car.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moveDistance = Vector3.Dot(car.transform.position - lastFramePos,car.transform.forward);
        int speed = (int)(moveDistance*10/Time.deltaTime);
        text.text = speed.ToString()+"Km/H";
        pin.transform.rotation = Quaternion.Euler(0, 0, -speed);
        lastFramePos = car.transform.position;
    }
}
