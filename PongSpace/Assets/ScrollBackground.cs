using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float width = 14.6f;
    public float speedX = -1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        if (transform.position.x <= -1 * width)
        {
            transform.Translate(1 * width, 0, 0);
        }
    }
}
