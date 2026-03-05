using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    private bool scored = false;

    public void SetGameController(GameController gc)
    {
        gameController = gc;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered by: " + other.name);

        if (scored) return;

        if (other.GetComponent<Bird>() != null)
        {
            scored = true;
            Debug.Log("Scored!");
            gameController.AddScore();
        }
    }

   
}
