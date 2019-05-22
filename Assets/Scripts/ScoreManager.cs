using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public Text scoreText;

    public void AddScore(int _score)
    {
        score += _score;
        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = score.ToString();
    }
}
