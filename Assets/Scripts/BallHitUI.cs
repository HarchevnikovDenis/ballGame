using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallHitUI : MonoBehaviour
{
    void Awake()
    {
        int ballHit = PlayerPrefs.GetInt("ballHit", 0);
        gameObject.GetComponent<Text>().text = "BallHit: " + ballHit;
    }
}
