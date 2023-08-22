using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public float speed;


    /*float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");
    Vector3 p = transform.position;
    p.x+=moveX*speed*Time.deltaTime;
    p.y=moveY*speed*Time.deltaTime;
    transform.position=p;*/

    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        if(Input.GetKey(KeyCode.LeftArrow))
        {
         transform.Translate(Vector2.left*speed );
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed);
        }





    }

}
