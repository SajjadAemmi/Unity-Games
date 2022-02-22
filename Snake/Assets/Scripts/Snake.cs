using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Snake : MonoBehaviour
{
    Vector2 dir = Vector2.right;
    List<Transform> tail = new List<Transform>();
    bool ate = false;
    public GameObject Body;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Move", 0.3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            dir = Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow))
            dir = -Vector2.up;    // '-up' means 'down'
        else if (Input.GetKey(KeyCode.LeftArrow))
            dir = -Vector2.right; // '-right' means 'left'
        else if (Input.GetKey(KeyCode.UpArrow))
            dir = Vector2.up;
    }

    void OnTriggerEnter2D(Collider2D target) 
    {
        // Food?
        if (target.name.StartsWith("Food")) 
        {
            // Get longer in next Move call
            ate = true;
        
            // Remove the Food
            Destroy(target.gameObject);
        }
        // Collided with Tail or Border
        else 
        {
            // ToDo 'You lose' screen
        }
    }

    void Move() 
    {
        // Save current position (gap will be here)
        Vector2 v = transform.position;

        // Move head into new direction (now there is a gap)
        transform.Translate(dir);

        // Ate something? Then insert new Element into gap
        if (ate) 
        {
            // Load Prefab into the world
            GameObject g = (GameObject)Instantiate(Body, v, Quaternion.identity);

            // Keep track of it in our tail list
            tail.Insert(0, g.transform);

            // Reset the flag
            ate = false;
        }
        // Do we have a Tail?
        else if (tail.Count > 0) 
        {
            // Move last Tail Element to where the Head was
            tail.Last().position = v;

            // Add to front of list, remove from the back
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count-1);
        }
    }
}
