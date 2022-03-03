using System.Collections;
//次は、playerが動くときに生じる違和感をなくして。。。
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
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
        if (this.rigid2D.velocity.y == 0.0 &&
                Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up/5);
        }

        if (Input.GetKey(KeyCode.Alpha1) &&
            Input.GetKey(KeyCode.Alpha7) &&
            Input.GetKey(KeyCode.Alpha0))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up /60);
        }

        if (this.rigid2D.velocity.y == 0.0 &&
                Input.GetKey(KeyCode.UpArrow))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up /5);
        }

        if (transform.position.y > 35 &&
            transform.position.x < -2150 &&
            transform.position.x > -2250)
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up / -800);
        }
        if (transform.position.y > 35 &&
            transform.position.x > -2150)
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up / -800);
        }
        if (transform.position.y > 35 &&
            transform.position.x < -2250)
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up / -800);
        }

        //左右移動

        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
            this.animater.SetTrigger("Walk");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
            this.animater.SetTrigger("Walk");
        }
        float qwe = Mathf.Abs(this.rigid2D.velocity.x);
        if (qwe < this.wqw)
        {
            this.rigid2D.AddForce(transform.right * key /50);
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