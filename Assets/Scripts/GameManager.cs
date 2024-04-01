using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{

    [SerializeField] private TextMeshProUGUI scoreField;
    
    [SerializeField] public bool isGameStarted = false;


    private int score = 0;

    public void IncreaseScore(int scoreValue)
    {
        score += scoreValue;
        scoreField.text = score.ToString();
    }

    public void StartGame()
    {
        isGameStarted = true;
    }

}
