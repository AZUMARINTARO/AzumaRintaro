using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
    }
    void OnTriggerExit2D(Collider2D other)
    {

        SceneManager.LoadScene("stagee");
    }
}
