using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public bool isPlayer1; //determine player
    public float speed; //ball speed
    public Rigidbody2D rb; //reference to rigidbody of the ball

    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isPlayer1) //checks if player 1
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else //player 2
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
