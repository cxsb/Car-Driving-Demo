using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour
{
    public float secondsToFixCamera = 3;
    Coroutine coroutineFixCamera = null;
    private bool fixCamera;
    public GameObject tracingObj;
    public Vector3 posOffset = new Vector3(0,3,-7);
    // Update is called once per frame
    void Update()
    {
        var pos = tracingObj.transform.position;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        if(System.Math.Abs(mouseX)<0.1 && System.Math.Abs(mouseY)<0.1)
        {
            if(coroutineFixCamera == null)
            {
                coroutineFixCamera = StartCoroutine(CoroutineFixCamera());
            }
        }
        else
        {
            if(coroutineFixCamera != null)
            {
                StopCoroutine(coroutineFixCamera);
                coroutineFixCamera = null;
                fixCamera = false;
            }
        }

        if(fixCamera) transform.rotation = Quaternion.Lerp(transform.rotation,tracingObj.transform.rotation,2f * Time.deltaTime);

        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"),0,0),Space.Self);
        transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X"),0),Space.World);
        transform.position = pos + transform.rotation * posOffset;
    }

    IEnumerator CoroutineFixCamera()
    {
        yield return new WaitForSeconds(secondsToFixCamera);
        fixCamera = true;
        coroutineFixCamera = null;
    }
}
