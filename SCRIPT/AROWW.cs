using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AROWW : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 49)
        {
            Destroy(gameObject);
        }
        transform.Translate(0, -0.05f, 0);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ARROW")
        {
            SceneManager.LoadScene("GAMEOVER");
        }
    }
}
