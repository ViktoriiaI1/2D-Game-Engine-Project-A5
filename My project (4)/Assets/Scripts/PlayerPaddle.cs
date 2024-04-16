
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _derection;
    public float strangth = 1;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
           _derection= Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _derection = Vector2.down;
        }
        else
        {
            _derection = Vector2.zero;
        }
     
    }
    private void FixedUpdate()
    {
        if (_derection.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_derection * this.speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 force = Vector2.right * strangth;
        collision.rigidbody.AddForce(force, ForceMode2D.Impulse);
        //Debug.Log(collision.otherCollider.gameObject.name);
    }

}
