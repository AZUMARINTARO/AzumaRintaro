using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KYORIのHYOUZI : MonoBehaviour
{
    GameObject Camera;
    GameObject flag;
    GameObject DISTANCE;
    // Start is called before the first frame update
    void Start()
    {
        this.Camera = GameObject.Find("Camera");
        this.flag = GameObject.Find("flag");
        this.DISTANCE = GameObject.Find("DISTANCE");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 bbb = this.Camera.transform.position;
        Vector2 ccc = this.flag.transform.position;
        Vector2 aaa = this.flag.transform.position -
            this.Camera.transform.position;
        float dd = aaa.magnitude;
        this.DISTANCE.GetComponent<Text>().text="ゴールまであと、" +dd + "m";

        if (dd<=0)
        {
            this.DISTANCE.GetComponent<Text>().text = "ゴールまであと、" +"0.0000m";
        }
        
    }
}
