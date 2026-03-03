using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Actions : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {

        if (GameController.Instance == null)
        {
            Debug.LogError("GameController Instance is NULL");
            return;
        }

        if (Input.touchCount > 0) {
            if (Input.touches[0].phase == TouchPhase.Began) {
                Debug.Log("touched");
                GameController.Instance.bird.GoUp();
            }
        }
    }
}
