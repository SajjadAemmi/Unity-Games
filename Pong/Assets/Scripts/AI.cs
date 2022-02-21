using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed = 30;
    public GameObject ball;
    float direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float rocket_y = transform.position.y;
        float rocket_h = GetComponent<BoxCollider2D>().transform.localScale.y;
        float ball_y = ball.transform.position.y;
        float ball_x = ball.transform.position.x;

        if(ball_x > 0)
        {
            if(rocket_y > ball_y + rocket_h)
            {
                direction = -1;
            }
            else if(rocket_y < ball_y - rocket_h)
            {
                direction = 1;
            }
            else
            {
                direction = 0;
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction) * speed;
        }        
    }
}
