using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject flag;
    Rigidbody2D rigid2D;
    float jump = 3f;
    float wqw = 15;

    Animator animater;

    void Start()
    {
        this.flag = GameObject.Find("flag");
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animater = GetComponent<Animator>();
    }
    void Update()
    {
            int key = 0;
        if (Input.GetKey(KeyCode.I)&&
            Input.GetKey(KeyCode.N))
            {
            this.animater.SetTrigger("jump");
            transform.Translate(-1,1, 0);
        }
                if (Input.GetKey(KeyCode.P))
            {
            this.animater.SetTrigger("jump");
            transform.Translate(3, 2, 0);
            }

            if (this.rigid2D.velocity.y == 0.0 &&
                Input.GetKeyDown(KeyCode.UpArrow))
            {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up /10);
            }


            if (this.rigid2D.velocity.y == 0.0 &&
                        Input.GetKeyDown(KeyCode.UpArrow))
            {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up /10);
            }

            if (this.rigid2D.velocity.y == 0.0 &&
                    Input.GetKey(KeyCode.UpArrow))
            {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up/10);
            }

            if (transform.position.y > 38 &&
                transform.position.x > -2250)
            {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up / -500);
                this.animater.SetTrigger("Walk");
            }
            if (transform.position.y > 30 &&
                    transform.position.y < 50)
            {
                key = 0;
            }
            //¶‰EˆÚ“®

            if (Input.GetKey(KeyCode.RightArrow))
            {
                key = 1;
                this.animater.SetTrigger("Walk");
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    key = -1;
                    this.animater.SetTrigger("Walk");
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                key = -1;
                this.animater.SetTrigger("Walk");
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    key = 1;
                    this.animater.SetTrigger("Walk");
                }
            }
            float qwe = Mathf.Abs(this.rigid2D.velocity.x);
            if (qwe < this.wqw)
            {
                this.rigid2D.AddForce(transform.right * key /40);
            }
            if (this.rigid2D.velocity.y != 0)
            {
                this.animater.speed = 1.0f;
            }
            if (transform.position.y < -30)
            {
                SceneManager.LoadScene("GAMEOVER");
            }
            if (key != 0)
            {
                this.rigid2D.AddForce(transform.right * key / 650);
                transform.localScale = new Vector3(key * 15, 15, 1);
            }

        }
}