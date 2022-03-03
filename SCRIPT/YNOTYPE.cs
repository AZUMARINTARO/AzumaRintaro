using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class YNOTYPE : MonoBehaviour
{
    GameObject Camera;
    GameObject flag;
    GameObject TEE;
    // Start is called before the first frame update
    void Start()
    {
        this.Camera = GameObject.Find("Camera");
        this.flag = GameObject.Find("flag");
        this.TEE = GameObject.Find("TEE");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 bbb = this.Camera.transform.position;
        Vector2 ccc = this.flag.transform.position;
        Vector2 aaa = this.flag.transform.position-
            this.Camera.transform.position;
        float dd = aaa.magnitude/10;
        this.TEE.GetComponent<Text>().text = "ゴールまであと、" + dd+ "m";

        if (dd < 0)
        {
            this.TEE.GetComponent<Text>().text = "ゴールまであと、" + "0.0000m";
        }

    }
}
