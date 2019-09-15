using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformColorChanging : MonoBehaviour
{
    private SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Color randomColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            rend.material.color = randomColor; 
        }
    }
}
