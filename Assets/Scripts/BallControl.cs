using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    public Vector2 speed;
    public Vector2 resetPosition;
    public Collider2D paddleKanan;
    public Collider2D paddleKiri;

    private Rigidbody2D rig;
    public bool isRight;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        rig.velocity = speed;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == paddleKanan)
        {
            isRight = true;
        }
        else if (collision.collider == paddleKiri)
        {
            isRight = false;
        }
    }
}
