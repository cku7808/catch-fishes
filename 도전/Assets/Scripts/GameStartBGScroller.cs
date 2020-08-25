using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartBGScroller : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Repeat(-Time.time * scrollSpeed, transform.localScale.y);
        transform.position = newPosition;
    }
}
