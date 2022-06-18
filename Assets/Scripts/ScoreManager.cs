using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;

    public int maxScore;

    public BallControl ball;
    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.speed.x = 5;
        ball.ResetBall();
        if(rightScore >= maxScore)
        {
            GameOver();
        }
    }
    
    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.speed.x = -5;
        ball.ResetBall();
        if(leftScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
