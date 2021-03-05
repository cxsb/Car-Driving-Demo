using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject panel;
    public UnityEngine.UI.Text text,text1;
    public int powerPickUp;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.GetComponent<PowerUp>()!=null)
        {
            powerPickUp++;
            Destroy(collider.gameObject);
        }
        if(collider.gameObject.GetComponent<FinalGate>()!=null)
        {
            ShowFinalPanel();
            Destroy(collider.gameObject);
        }
    }

    private void ShowFinalPanel()
    {
        panel.SetActive(true);
        text.text = "PowerUp Picked : " + powerPickUp.ToString();
        text1.text = "Time Total : " + (Time.time-time).ToString();
    }
}
