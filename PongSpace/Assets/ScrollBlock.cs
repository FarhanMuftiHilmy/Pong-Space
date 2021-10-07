using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBlock : MonoBehaviour
{
    public float width = 20.48f;
    public float height = 10.24f;
    public float speedX = -2;

    // Update is called once per frame
    void Start()
    {
        transform.Translate(0, height, 0);
        transform.position = new Vector2(Random.Range(-4.5f, 4.5f), transform.position.y);
    }

    void Update()
    {
        transform.Translate(0, speedX * Time.deltaTime, 0);
        if (transform.position.y <= -1 * height)
        {
            transform.Translate(0, 2 * height, 0);
            transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
            transform.position = new Vector2(Random.Range(-4.5f, 4.5f), transform.position.y);
        }
    }
}
