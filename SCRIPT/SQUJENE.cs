using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQUJENE : MonoBehaviour
{
    public GameObject square;
    public GameObject square2;
    public AudioClip dorn;
    public AudioClip rappa;
    GameObject Camera;
    GameObject Cat;
    GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        this.Camera = GameObject.Find("Camera");
        this.Cat = GameObject.Find("cat");
        this.cat = GameObject.Find("ga");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) &&
            this.Camera.transform.position.x >= -105 &&
            this.Cat.transform.position.y <= 55&&
             this.Cat.transform.position.x>=-105)
        {
            Destroy(this.cat);
            this.Camera.transform.position = new Vector3(-97, 51, -10);
            GetComponent<AudioSource>().Play();
            GameObject prehab2 = Instantiate(square2);
            prehab2.transform.position = new Vector3(-914 / 10, 40, 0);
        }
        }

    }