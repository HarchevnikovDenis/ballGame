using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
            Movement(Input.GetAxis("Horizontal"));

    }

    void Movement(float dir)
    {
        rb.AddForce(new Vector2(dir * speed, 0), ForceMode2D.Force);
    }
}
