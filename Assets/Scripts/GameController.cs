using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

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

        if (gameOverUI != null) gameOverUI.Show();
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
