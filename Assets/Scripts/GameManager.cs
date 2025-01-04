using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] private GameObject levelFinishedScreen;
    [SerializeField] private GameObject inGameScreen;
    
    
    [SerializeField] private TextMeshProUGUI scoreField;
    [SerializeField] private TextMeshProUGUI finishScreenScoreField;
    
    
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

    public void LevelFinished()
    {
        inGameScreen.SetActive(false);
        levelFinishedScreen.SetActive(true);
        finishScreenScoreField.text = score.ToString();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
