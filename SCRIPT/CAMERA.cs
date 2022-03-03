using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CAMERA : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G) &&
            Input.GetKey(KeyCode.A)&&
            transform.position.x==-120)
        {
            
            transform.position = new Vector3(-100, 51, -10);
        }
    }
}
