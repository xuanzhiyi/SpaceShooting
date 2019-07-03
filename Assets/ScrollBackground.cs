using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    float scrollSpeed = -5f;

    Vector2 startPos;

    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 41);
        transform.position = startPos + Vector2.up * newPos;
    }

}
