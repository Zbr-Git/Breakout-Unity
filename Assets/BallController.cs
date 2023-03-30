using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 500f;
    public Rigidbody2D rb2D;
    
    private void Start()
    {
        Invoke(nameof(SetRandomMovement), 1f);
    }
    
    private void SetRandomMovement()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.5f, 0.5f);
        force.y = -1f;
        rb2D.AddForce(force.normalized * speed);
    }
}

