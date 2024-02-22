using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text textScore;
    public int score = 0;



    public void AddScore()
    {
        score++;
        textScore.text = "Score: " + score;
    }
    public void AddScore5()
    {
        score += 5;
        textScore.text = "Score: " + score;
    }
}
