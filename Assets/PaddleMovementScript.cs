using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementScript : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speed = 5.0f;
    
  
    private void FixedUpdate()
    {
        
        float moveHorizontal = 0.0f;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal = -1.0f;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = 1.0f;
        }

       //float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        rb2D.velocity = movement * speed;
    }
}
