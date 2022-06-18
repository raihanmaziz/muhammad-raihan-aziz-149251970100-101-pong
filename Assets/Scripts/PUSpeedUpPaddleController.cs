using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D paddleKanan;
    public Collider2D paddleKiri;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleKanan.GetComponent<PaddleController>().ActivatePUSpeedUpPaddle();
            paddleKiri.GetComponent<PaddleController>().ActivatePUSpeedUpPaddle();
            manager.RemovePowerUp(gameObject);
        }
    }
}
