using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _speed = 8.0f;

    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right*_speed*horizontalInput*Time.deltaTime);

        if (transform.position.x < -10.7f)
        {
            transform.position = new Vector2(10.7f, transform.position.y);

        }

        if (transform.position.x > 10.7f)
        {
            transform.position = new Vector2(-10.7f, transform.position.y);

        }
    }

}
