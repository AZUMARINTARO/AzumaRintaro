using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    GameObject Camera;
    GameObject flag;
    Rigidbody2D rigid2D;
    float jump = 3f;
    Animator animater;
    float max = 5.0f;//ç≈èâÇ…ïœêîÇéwíË
    // Start is called before the first frame update
    void Start()
    {
        this.Camera = GameObject.Find("Camera");
        this.flag = GameObject.Find("flag");
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animater = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.rigid2D.velocity.y == 0.0 &&
           Input.GetKey(KeyCode.UpArrow))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up /20);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) &&
            Input.GetKeyDown(KeyCode.K) &&
            Input.GetKeyDown(KeyCode.O))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.right);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) &&
           Input.GetKeyDown(KeyCode.K) &&
           Input.GetKeyDown(KeyCode.O))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.right / 30);
        }
        if (Input.GetKey(KeyCode.LeftShift) &&
            Input.GetKey(KeyCode.K) &&
            Input.GetKey(KeyCode.O))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.right / 30);
        }
        if (Input.GetKey(KeyCode.RightShift) &&
           Input.GetKey(KeyCode.K) &&
           Input.GetKey(KeyCode.O))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.right / 30);
        }
        if (this.rigid2D.velocity.y == 0.0 &&
            Input.GetKey(KeyCode.UpArrow))
        {
            this.animater.SetTrigger("jump");
            this.rigid2D.AddForce(this.jump * transform.up / 40 * 3);
        }

        //ç∂âEà⁄ìÆ
        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
            this.animater.SetTrigger("Walk");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
            this.animater.SetTrigger("Walk");
        }
        float speed = Mathf.Abs(this.rigid2D.velocity.x);
        if (speed < this.max)
        {
           
            this.rigid2D.AddForce(transform.right * key/100);
        }

        if (transform.position.y <-10)
        {
            SceneManager.LoadScene("GAMEOVER");
        }
        if (key!=0)
        {
            transform.localScale = new Vector3(key* 3, 3, 1);
        }
    }
}
