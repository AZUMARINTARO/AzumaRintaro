using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SINE1234 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ARROW")
        {
            SceneManager.LoadScene("GAMEOVER");
        }
    }
}