using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10.0f;
    private int ballHit;

    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        ballHit = PlayerPrefs.GetInt("ballHit", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
            Movement();

    }

    void Movement()
    {
        Touch touch = Input.GetTouch(0);

        if (touch.position.x > Camera.main.pixelWidth / 2)
            rb.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
        else
            rb.AddForce(new Vector2(-speed, 0), ForceMode2D.Force);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            ballHit++;
            PlayerPrefs.SetInt("ballHit", ballHit);
        }
    }
}
