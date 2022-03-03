using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI4 : MonoBehaviour
{
    GameObject Counter;
    GameObject Camera;
    GameObject bosi;
    GameObject aaa;
    GameObject UI;
    GameObject Aoeng;
    GameObject cloud;
    GameObject hint;
    GameObject sunawati;
    public GameObject flower;
    public float finish = 0;
    public float delta = 3;
    public float timer = 0;
    int rando = 2;
    public GameObject arrow;
    public GameObject flag;
    // Start is called before the first frame update
    void Start()
    {
        this.hint = GameObject.Find("hint");
        this.sunawati = GameObject.Find("sunawati");
        this.cloud = GameObject.Find("cloud12");
        this.Aoeng = GameObject.Find("aoing");
        this.Camera = GameObject.Find("Camera");
        this.Counter = GameObject.Find("Counter");
        this.bosi = GameObject.Find("bosi");
        this.UI = GameObject.Find("UI");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.Camera.transform.position.x >= -97.5)
        {
            this.delta -= Time.deltaTime;
            this.Counter.GetComponent<Text>().text = this.delta.ToString("F0");
            if (this.delta <= 1 &&
                this.delta > 0)
            {
                this.Counter.GetComponent<Text>().text = "GO";
            }

            if (this.delta <= 0)
            {
                int dice = Random.Range(1, 11);
                GameObject prehabb;
                this.Counter.GetComponent<Text>().text = "Å@";
                Destroy(this.bosi);
                this.delta = 0;
                this.finish += Time.deltaTime;
                this.timer += Time.deltaTime;

                if (dice <= this.rando)
                {
                    if (this.timer >= 1.0f)
                    {
                        prehabb = Instantiate(arrow);
                        float x = Random.Range(-104, -103f);
                        prehabb.transform.position = new Vector3(x, 55, 0);
                        this.timer = 0;
                    }
                }

                if (this.timer >= 1.0f)
                {
                    prehabb = Instantiate(arrow);
                    float x = Random.Range(-105, -91f);
                    prehabb.transform.position = new Vector3(x, 55, 0);
                    this.timer = 0;
                }

                if (this.finish >= 15)
                {
                    this.Aoeng.transform.Translate(0, -0.03f, 0);
                    prehabb = Instantiate(arrow);
                    prehabb.transform.position = new Vector3(0, 0, 0);
                }
            }
        }

                if (this.finish > 182 / 10)
                {
                    this.Aoeng.transform.position = new Vector3(-98, 50, 0);
                }


            if (Input.GetKey(KeyCode.B) &&
       Input.GetKey(KeyCode.L) &&
       Input.GetKey(KeyCode.U) &&
       Input.GetKey(KeyCode.E))
            {
                this.hint.transform.position = new Vector3(-111, 53, 0);
                this.cloud.transform.position = new Vector3(-1045 / 10, 49, 0);
                this.Camera.transform.position = new Vector3(-105, 51, -11);
            }

            if (Input.GetKey(KeyCode.A) &&
            Input.GetKey(KeyCode.O) &&
           Input.GetKey(KeyCode.E) &&
           Input.GetKey(KeyCode.N) &&
           Input.GetKey(KeyCode.G))
            {
                this.flag.transform.position = new Vector3(-108, 503 / 2, 0);
                Destroy(this.flower);
            }
        }
    }