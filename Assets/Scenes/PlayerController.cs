using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2D;
    float jumpForce = 680.0f;
    float maxWalkSpeed=100;
    float walkForce = 10;

    void Start()
    {
        //フレームカウント
        Application.targetFrameRate = 60;
        //
        this.rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.rigidbody2D.AddForce(transform.up * this.jumpForce);
        }
        int key = 0;
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            key = 1;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            key = -1;
        }

        //
        float speed = Mathf.Abs(this.rigidbody2D.velocity.x);
        if(speed<this.maxWalkSpeed)
        {
            this.rigidbody2D.AddForce(transform.right * key * this.walkForce);
        }
        if(key!=0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}
