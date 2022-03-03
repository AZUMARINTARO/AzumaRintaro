using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AAAAA : MonoBehaviour
{
    // Update is called once per frame
    public void naaa()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("unity-part-6");
        }
    }
}