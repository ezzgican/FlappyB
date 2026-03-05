using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Actions : MonoBehaviour
{

    [SerializeField] private GameController gameController;
    [SerializeField] private Bird bird;

    void Update()
    {
       

        bool tapped =
            (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            || Input.GetMouseButtonDown(0); // editor test için

        if (!tapped) return;

        // oyun baþlamadýysa baþlat
        if (!gameController.IsPlaying())
        {
            gameController.StartGame();
            return;
        }

        // playing ise zýplat
        bird.GoUp();
    }
}
