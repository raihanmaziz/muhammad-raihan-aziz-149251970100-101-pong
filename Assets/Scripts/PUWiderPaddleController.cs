using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUWiderPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D paddleKanan;
    public Collider2D paddleKiri;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleKanan.GetComponent<PaddleController>().ActivatePUWiderPaddle();
            paddleKiri.GetComponent<PaddleController>().ActivatePUWiderPaddle();
            manager.RemovePowerUp(gameObject);
        }
    }
}
