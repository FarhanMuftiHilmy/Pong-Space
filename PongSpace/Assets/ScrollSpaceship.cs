using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSpaceship : MonoBehaviour
{
    public float width = 14.6f;
    public float speedX = 1;

    // Update is called once per frame
    void Start()
    {
        //spaceship datang dari kanan ke kiri
        if (speedX < 0)
        {
            transform.Translate(width, 0, 0);
            transform.position = new Vector2(transform.position.x, Random.Range(-2f, 2f));
        }
        else //spaceship datang dari kiri ke kanan
        {
            transform.Translate(-width, 0, 0);
            transform.position = new Vector2(transform.position.x, Random.Range(-2f, 2f));
        }
           
    }

    void Update()
    {
        //spaceship datang dari kanan ke kiri
        if (speedX < 0)
        {
            transform.Translate(speedX * Time.deltaTime, 0, 0);
            if (transform.position.x <= -1 * width)
            {
                transform.Translate(2 * width, 0, 0);
                transform.position = new Vector2(transform.position.x, Random.Range(-2f, 2f));
            }
        }
        else //spaceship datang dari kiri ke kanan
        {
            transform.Translate(speedX * Time.deltaTime, 0, 0);
            if (transform.position.x >= 1 * width)
            {
                transform.Translate(-2 * width, 0, 0);
                transform.position = new Vector2(transform.position.x, Random.Range(-2f, 2f));
            }
        }
        
    }
}
