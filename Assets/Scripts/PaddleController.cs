using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    public float powerUpDuration;
    public Vector2 resetSize;
    public Vector2 widerSize;
    public int resetSpeed;
    public int speedUpSpeed;

    private Rigidbody2D rig;

    private float timerWider;
    private float timerSpeed;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        timerWider += Time.deltaTime;
        timerSpeed += Time.deltaTime;
        MoveObject(GetInput());

        if (timerWider >= powerUpDuration)
        {
            transform.localScale = resetSize;
        }

        if (timerSpeed >= powerUpDuration)
        {
            speed = resetSpeed;
        }
    }

    private Vector2 GetInput()
    {
        if(Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if(Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Paddle Speed: " + movement);
        rig.velocity = movement;
    }

    public void ActivatePUWiderPaddle()
    {
        timerWider = 0;
        transform.localScale = widerSize;
    }

    public void ActivatePUSpeedUpPaddle()
    {
        timerSpeed = 0;
        speed = speedUpSpeed;
    }
}
