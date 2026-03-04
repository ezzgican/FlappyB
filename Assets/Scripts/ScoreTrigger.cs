using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool scored = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered by: " + other.name);

        if (scored) return;

        if (other.GetComponent<Bird>() != null)
        {
            scored = true;
            Debug.Log("Scored!");
            GameController.Instance.AddScore();
        }
    }
}
