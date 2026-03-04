using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI gameOverScoreText;

    
    public void Show(int score)
    {
        gameObject.SetActive(true);

       
        gameOverScoreText.text = "Score: " + score;
    }

    public void Hide()
    {
       gameObject.SetActive(false);
    }

    // Restart butonuna bunu baðla
    public void OnClickRestart()
    {
        Debug.Log("Restart pressed");
        GameController.Instance.Restart();
    }
}
