using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] float speed = 2.2f;
    [SerializeField] float destroyX = -6f;

    Rigidbody2D rb;

    void Awake() => rb = GetComponent<Rigidbody2D>();

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.left * speed * Time.fixedDeltaTime);

        if (rb.position.x < destroyX)
            Destroy(gameObject);
    }
}