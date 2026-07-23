using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector2 direction;
    void Start()
    {
    direction = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }
    private Vector2 Move()
    {
        return new Vector2(0,0); 
    }
}
