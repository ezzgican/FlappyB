using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    

    [SerializeField] private float jumpForce = 5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true; // kuþ dönmesin (opsiyonel ama faydalý)
    }

    public void GoUp()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}
