using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;
    private int scorePoints;

    public void ScoreUpdate(int score)
    {
        scorePoints += score;
        ScoreText.text = scorePoints.ToString();
    }
}
