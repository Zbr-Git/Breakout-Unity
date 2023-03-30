using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBrick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.gameObject.CompareTag("Ball"))
        {
            return;
        }
        //Debug.Log("Deleted");
        Destroy(gameObject);
    }
}
 