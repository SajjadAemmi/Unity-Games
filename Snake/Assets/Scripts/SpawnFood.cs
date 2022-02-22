using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject Food;

    // Borders
    public Transform BorderTop;
    public Transform BorderBottom;
    public Transform BorderLeft;
    public Transform BorderRight;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn food every 4 seconds, starting in 3
        InvokeRepeating("Spawn", 3, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Spawn one piece of food
    void Spawn() 
    {
        // x position between left & right border
        int x = (int)Random.Range(BorderLeft.position.x, BorderRight.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(BorderBottom.position.y, BorderTop.position.y);

        // Instantiate the food at (x, y)
        Instantiate(Food,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }
}
