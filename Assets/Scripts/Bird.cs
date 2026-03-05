using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    [SerializeField] private float jumpForce = 5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    public void SetSimulated(bool value)
    {
        // value=false iken kuþ düþmez/haraket etmez
        rb.simulated = value;

        if (!value)
            rb.velocity = Vector2.zero;
    }

    public void GoUp()
    {
        rb.velocity = new Vector2(0f, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Playing deðilse çarpýþmayý görmezden gel (ör. start öncesi)
        
        if (!gameController.IsPlaying()) return;

        // Pipe veya base'e çarptýysa game over
        gameController.GameOver();
    }
}
