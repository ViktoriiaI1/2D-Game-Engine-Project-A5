
using System.Runtime.CompilerServices;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    public float Gap;
    private void Update()
    {
        Vector3 movement = Vector3.zero;

        if (ball.position.y > transform.position.y + Gap)
        {
            movement = Vector3.up;
        }
        else if (ball.position.y < transform.position.y - Gap)
        {
            movement = Vector3.down;
        }

        this.transform.position += movement * speed * Time.deltaTime;
    }
    
        

          
        
        
    
}
