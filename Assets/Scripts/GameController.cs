using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject scoreUI;


    private int score = 0;
    public int Score => score;

    public enum GameState {
        WaitingToStart,
        Playing,
        GameOver
    }
    public GameState State { get; private set; } = GameState.WaitingToStart;

    [Header("References")]
    public Bird bird;
    [SerializeField] private GameOverUI gameOverUI;

    private void Awake()
    {
        Instance = this;
        Application.targetFrameRate = 60;

        // Oyun baþta duruyor (UI kapalý)
        Time.timeScale = 1f;
        State = GameState.WaitingToStart;

        if (gameOverUI != null) gameOverUI.Hide();
        
    }

    private void Start()
    {
        if (bird != null)
            bird.SetSimulated(false);

        scoreUI.SetActive(true);

        score = 0;
        scoreText.text = "Score: 0";
    }

    public bool IsPlaying() => State == GameState.Playing;

    public void StartGame()
    {
        if (State != GameState.WaitingToStart) return;

        State = GameState.Playing;
        bird.SetSimulated(true);
    }

    public void GameOver()
    {
        

        if (State == GameState.GameOver) return;

        State = GameState.GameOver;

        // oyun dursun
        Time.timeScale = 0f;

        scoreUI.SetActive(false);

        if (gameOverUI != null) gameOverUI.Show(score);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
