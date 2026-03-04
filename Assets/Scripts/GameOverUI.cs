using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    

    public void Show()
    {
        gameObject.SetActive(true);
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
