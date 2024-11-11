using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{

    [SerializeField] private TextMeshProUGUI scoreField;
    
    [SerializeField] public bool isGameStarted = false;



    [SerializeField] private VoidEvent OnPlayerCollideFinishObject;
    
    [SerializeField] private IntEvent OnScoreGained;

    
    private int score = 0;


    private void OnEnable()
    {
        OnPlayerCollideFinishObject.AddListener(FinishGame);
        OnScoreGained.AddListener(IncreaseScore);
    }

    private void OnDisable()
    {
        OnPlayerCollideFinishObject.RemoveListener(FinishGame);
        OnScoreGained.RemoveListener(IncreaseScore);
    }


    public void IncreaseScore(int scoreValue)
    {
        score += scoreValue;
        scoreField.text = score.ToString();
    }

    public void StartGame()
    {
        isGameStarted = true;
    }

    private void FinishGame()
    {
        this.isGameStarted = false;
    }

}
