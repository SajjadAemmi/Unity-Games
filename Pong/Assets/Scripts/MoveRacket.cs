using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;

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
       float v = Input.GetAxisRaw("Vertical");
       GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
