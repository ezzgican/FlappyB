using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Actions : MonoBehaviour
{



    void Update()
    {
        if (GameController.Instance == null) return;

        bool tapped =
            (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            || Input.GetMouseButtonDown(0); // editor test için

        if (!tapped) return;

        // oyun baþlamadýysa baþlat
        if (!GameController.Instance.IsPlaying())
        {
            GameController.Instance.StartGame();
            return;
        }

        // playing ise zýplat
        GameController.Instance.bird.GoUp();
    }
}
