using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PARTICLE : MonoBehaviour
{
    GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        this.Camera = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ARROW"&&
            this.Camera.transform.position.z<=-10.1)
        {
            this.Camera.transform.position =new Vector3(-115, 51, -20);
        }
    }
}
